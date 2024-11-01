import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.Timer;
import java.util.TimerTask;
import java.util.Random;
import javax.sound.sampled.*;
import java.io.File;
import java.io.IOException;

class BlockPanel extends JPanel {
    private String[][] grid;
    private int rows;
    private int cols;
    private int cellSize = 40; // Size of each block
    private int score = 0;
    private JLabel scoreLabel;

    public BlockPanel(int rows, int cols, JLabel scoreLabel) {
        this.rows = rows;
        this.cols = cols;
        this.scoreLabel = scoreLabel;
        grid = new String[rows][cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                grid[i][j] = "air"; // Fill grid with "air" initially
            }
        }

        setPreferredSize(new Dimension(cols * cellSize, rows * cellSize));
        addMouseListener(new MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent e) {
                int x = e.getX() / cellSize;
                int y = e.getY() / cellSize;
                if (SwingUtilities.isLeftMouseButton(e)) {
                    placeBlock(x, y, "stone");
                    playSound("place_block.wav");
                    score += 10;
                } else if (SwingUtilities.isRightMouseButton(e)) {
                    placeBomb(x, y);
                    score += 20;
                }
                updateScore();
                repaint(); // Redraw the panel after placing a block
            }
        });
    }

    public void placeBlock(int x, int y, String type) {
        if (x >= 0 && x < cols && y >= 0 && y < rows) {
            grid[y][x] = type;
        }
    }

    public void placeBomb(int x, int y) {
        if (x >= 0 && x < cols && y >= 0 && y < rows) {
            grid[y][x] = "bomb";
            Timer timer = new Timer();
            timer.schedule(new TimerTask() {
                @Override
                public void run() {
                    explodeBomb(x, y);
                    playSound("explosion.wav");
                }
            }, 1000); // Bomb explodes after 1 second
        }
    }

    public void explodeBomb(int x, int y) {
        int[][] directions = { {0, 0}, {1, 0}, {-1, 0}, {0, 1}, {0, -1} };
        for (int[] dir : directions) {
            int nx = x + dir[0];
            int ny = y + dir[1];
            if (nx >= 0 && nx < cols && ny >= 0 && ny < rows) {
                grid[ny][nx] = "fire";
            }
        }
        score += 50;
        updateScore();
        repaint();
    }

    public void updateScore() {
        scoreLabel.setText("Score: " + score);
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if ("stone".equals(grid[i][j])) {
                    g.setColor(Color.GRAY);
                } else if ("fire".equals(grid[i][j])) {
                    g.setColor(Color.RED);
                } else if ("bomb".equals(grid[i][j])) {
                    g.setColor(Color.BLACK);
                } else {
                    g.setColor(Color.CYAN); // Air is represented as cyan
                }
                g.fillRect(j * cellSize, i * cellSize, cellSize, cellSize);
                g.setColor(Color.BLACK);
                g.drawRect(j * cellSize, i * cellSize, cellSize, cellSize);
            }
        }
    }

    public void playSound(String soundFile) {
        try {
            File file = new File(soundFile);
            AudioInputStream audioStream = AudioSystem.getAudioInputStream(file);
            Clip clip = AudioSystem.getClip();
            clip.open(audioStream);
            clip.start();
        } catch (UnsupportedAudioFileException | IOException | LineUnavailableException ex) {
            ex.printStackTrace();
        }
    }
}

public class EnhancedMinecraftUI {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Enhanced Minecraft UI");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

            JLabel scoreLabel = new JLabel("Score: 0");
            scoreLabel.setFont(new Font("Arial", Font.BOLD, 20));
            frame.add(scoreLabel, BorderLayout.NORTH);

            BlockPanel blockPanel = new BlockPanel(10, 10, scoreLabel); // 10x10 grid
            frame.add(blockPanel);

            playBackgroundMusic("background_music.wav");

            frame.pack();
            frame.setLocationRelativeTo(null);
            frame.setVisible(true);
        });
    }

    public static void playBackgroundMusic(String musicFile) {
        try {
            File file = new File(musicFile);
            AudioInputStream audioStream = AudioSystem.getAudioInputStream(file);
            Clip clip = AudioSystem.getClip();
            clip.open(audioStream);
            clip.loop(Clip.LOOP_CONTINUOUSLY);
            clip.start();
        } catch (UnsupportedAudioFileException | IOException | LineUnavailableException ex) {
            ex.printStackTrace();
        }
    }
}
