import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.util.ArrayList;
import java.util.List;
import javax.sound.sampled.*;
import java.io.File;
import java.io.IOException;

// Main Game Panel
class GamePanel extends JPanel implements ActionListener {
    private Timer timer;
    private Player player;
    private List<Platform> platforms;
    private List<Enemy> enemies;
    private List<Item> items;
    private int score;
    private int playerHealth;
    private JLabel scoreLabel;
    private JLabel healthLabel;
    private boolean gameOver;

    public GamePanel() {
        setFocusable(true);
        setPreferredSize(new Dimension(800, 600));
        setBackground(Color.CYAN);

        player = new Player(50, 500); // Initial position
        platforms = new ArrayList<>();
        enemies = new ArrayList<>();
        items = new ArrayList<>();
        score = 0;
        playerHealth = 100;
        gameOver = false;

        // Create platforms
        platforms.add(new Platform(50, 550, 700, 50)); // Ground platform
        platforms.add(new Platform(200, 450, 150, 20));
        platforms.add(new Platform(400, 350, 150, 20));
        platforms.add(new Platform(600, 250, 150, 20));

        // Create enemies
        enemies.add(new Enemy(250, 400, 50, 50));
        enemies.add(new Enemy(450, 300, 50, 50));

        // Create items
        items.add(new Item(450, 320, 20, 20)); // Position above a platform
        items.add(new Item(650, 220, 20, 20));

        scoreLabel = new JLabel("Score: " + score);
        healthLabel = new JLabel("Health: " + playerHealth);

        add(scoreLabel);
        add(healthLabel);

        timer = new Timer(20, this);
        timer.start();

        addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                player.keyPressed(e);
            }

            @Override
            public void keyReleased(KeyEvent e) {
                player.keyReleased(e);
            }
        });

        playBackgroundMusic("background_music.wav");
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (gameOver) return;

        player.update();
        checkCollisions();
        checkGameOver();
        repaint();
    }

    private void checkCollisions() {
        for (Platform platform : platforms) {
            if (player.getBounds().intersects(platform.getBounds())) {
                player.collideWithPlatform(platform);
            }
        }

        for (Enemy enemy : enemies) {
            if (player.getBounds().intersects(enemy.getBounds())) {
                playerHealth -= 10;
                playSound("hit.wav");
                healthLabel.setText("Health: " + playerHealth);
                if (playerHealth <= 0) {
                    gameOver = true;
                }
            }
        }

        items.removeIf(item -> {
            if (player.getBounds().intersects(item.getBounds())) {
                score += 100;
                playSound("collect.wav");
                scoreLabel.setText("Score: " + score);
                return true;
            }
            return false;
        });
    }

    private void checkGameOver() {
        if (playerHealth <= 0) {
            gameOver = true;
            JOptionPane.showMessageDialog(this, "Game Over! Final Score: " + score);
        }
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        player.paint(g);

        for (Platform platform : platforms) {
            platform.paint(g);
        }

        for (Enemy enemy : enemies) {
            enemy.paint(g);
        }

        for (Item item : items) {
            item.paint(g);
        }

        // Game over screen
        if (gameOver) {
            g.setColor(Color.RED);
            g.setFont(new Font("Arial", Font.BOLD, 48));
            g.drawString("GAME OVER", 250, 300);
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

    public void playBackgroundMusic(String musicFile) {
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

// Player class
class Player {
    private int x, y;
    private int width, height;
    private int dx, dy;
    private boolean onGround;

    public Player(int x, int y) {
        this.x = x;
        this.y = y;
        this.width = 50;
        this.height = 50;
        this.dx = 0;
        this.dy = 0;
        this.onGround = false;
    }

    public void update() {
        x += dx;
        y += dy;

        if (!onGround) {
            dy += 1; // Gravity
        }

        if (y > 550) {
            y = 550;
            onGround = true;
        }

        if (x < 0) x = 0;
        if (x > 750) x = 750;
    }

    public void paint(Graphics g) {
        g.setColor(Color.BLUE);
        g.fillRect(x, y, width, height);
    }

    public void keyPressed(KeyEvent e) {
        int key = e.getKeyCode();

        if (key == KeyEvent.VK_LEFT) {
            dx = -5;
        }

        if (key == KeyEvent.VK_RIGHT) {
            dx = 5;
        }

        if (key == KeyEvent.VK_SPACE && onGround) {
            dy = -15;
            onGround = false;
        }
    }

    public void keyReleased(KeyEvent e) {
        int key = e.getKeyCode();

        if (key == KeyEvent.VK_LEFT || key == KeyEvent.VK_RIGHT) {
            dx = 0;
        }
    }

    public void collideWithPlatform(Platform platform) {
        if (dy > 0) {
            y = platform.getY() - height;
            dy = 0;
            onGround = true;
        }
    }

    public Rectangle getBounds() {
        return new Rectangle(x, y, width, height);
    }
}

// Platform class
class Platform {
    private int x, y, width, height;

    public Platform(int x, int y, int width, int height) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public void paint(Graphics g) {
        g.setColor(Color.GREEN);
        g.fillRect(x, y, width, height);
    }

    public int getY() {
        return y;
    }

    public Rectangle getBounds() {
        return new Rectangle(x, y, width, height);
    }
}

// Enemy class
class Enemy {
    private int x, y, width, height;
    private int dx = 2;

    public Enemy(int x, int y, int width, int height) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public void update() {
        x += dx;

        if (x < 0 || x > 750) {
            dx = -dx;
        }
    }

    public void paint(Graphics g) {
        g.setColor(Color.RED);
        g.fillRect(x, y, width, height);
        update(); // Move the enemy
    }

    public Rectangle getBounds() {
        return new Rectangle(x, y, width, height);
    }
}

// Item class
class Item {
    private int x, y, width, height;

    public Item(int x, int y, int width, int height) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public void paint(Graphics g) {
        g.setColor(Color.YELLOW);
        g.fillRect(x, y, width, height);
    }

    public Rectangle getBounds() {
        return new Rectangle(x, y, width, height);
    }
}

// Main Class
public class EnhancedMinecraftUI {
    public static void main(String[] args) {
        JFrame frame = new JFrame("2D Action-Adventure Game");
        GamePanel gamePanel = new GamePanel();
        frame.add(gamePanel);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setVisible(true);
    }
}
