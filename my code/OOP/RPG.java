public class RPG {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Select a character:");
        System.out.println("1. Warrior");
        System.out.println("2. Mage");
        System.out.println("3. Archer");

        int choice = scanner.nextInt();
        Character selectedCharacter;

        switch (choice) {
            case 1:
                selectedCharacter = new Warrior();
                break;
            case 2:
                selectedCharacter = new Mage();
                break;
            case 3:
                selectedCharacter = new Archer();
                break;
            default:
                System.out.println("Invalid choice. Defaulting to Warrior.");
                selectedCharacter = new Warrior();
                break;
        }

        selectedCharacter.attacking();
        selectedCharacter.defending();
        selectedCharacter.move();
    }
}

