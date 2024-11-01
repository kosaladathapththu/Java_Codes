using System;
using System.Collections.Generic;

// Define classes for entities
class Resident
{
    public int ResidentID { get; set; }
    public string Name { get; set; }
    public int RoomNumber { get; set; }
    public string ContactInfo { get; set; }
}

class Room
{
    public int RoomNumber { get; set; }
    public int Capacity { get; set; }
    public bool OccupancyStatus { get; set; }
}

class Fee
{
    public int FeeID { get; set; }
    public int ResidentID { get; set; }
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
}

class MaintenanceRequest
{
    public int RequestID { get; set; }
    public int ResidentID { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}

// Define a class for hostel management system
class HostelManagementSystem
{
    private List<Resident> residents = new List<Resident>();
    private List<Room> rooms = new List<Room>();
    private List<Fee> fees = new List<Fee>();
    private List<MaintenanceRequest> maintenanceRequests = new List<MaintenanceRequest>();

    // Method to register new resident
    public void RegisterResident(string name, int roomNumber, string contactInfo)
    {
        int residentID = residents.Count + 1;
        residents.Add(new Resident { ResidentID = residentID, Name = name, RoomNumber = roomNumber, ContactInfo = contactInfo });
        Console.WriteLine($"Resident {name} registered successfully with Resident ID: {residentID}");
    }

    // Method to allocate room to resident
    public void AllocateRoom(int residentID, int roomNumber)
    {
        Room room = rooms.Find(r => r.RoomNumber == roomNumber);
        if (room != null)
        {
            room.OccupancyStatus = true;
            Console.WriteLine($"Room {roomNumber} allocated to Resident ID: {residentID}");
        }
        else
        {
            Console.WriteLine($"Room {roomNumber} not found");
        }
    }

    // Method to record fee payment
    public void RecordFeePayment(int residentID, decimal amount, DateTime dueDate)
    {
        fees.Add(new Fee { FeeID = fees.Count + 1, ResidentID = residentID, Amount = amount, DueDate = dueDate });
        Console.WriteLine($"Fee payment recorded for Resident ID: {residentID}");
    }

    // Method to submit maintenance request
    public void SubmitMaintenanceRequest(int residentID, string description)
    {
        maintenanceRequests.Add(new MaintenanceRequest { RequestID = maintenanceRequests.Count + 1, ResidentID = residentID, Description = description, Status = "Pending" });
        Console.WriteLine($"Maintenance request submitted for Resident ID: {residentID}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of HostelManagementSystem
        HostelManagementSystem hostelManagementSystem = new HostelManagementSystem();

        // Register new residents
        hostelManagementSystem.RegisterResident("Alice", 101, "alice@example.com");
        hostelManagementSystem.RegisterResident("Bob", 102, "bob@example.com");

        // Allocate rooms to residents
        hostelManagementSystem.AllocateRoom(1, 101);
        hostelManagementSystem.AllocateRoom(2, 102);

        // Record fee payments
        hostelManagementSystem.RecordFeePayment(1, 100, DateTime.Now.AddDays(30));
        hostelManagementSystem.RecordFeePayment(2, 150, DateTime.Now.AddDays(30));

        // Submit maintenance requests
        hostelManagementSystem.SubmitMaintenanceRequest(1, "Leaking faucet");
        hostelManagementSystem.SubmitMaintenanceRequest(2, "Broken window");
        Console.ReadKey();
    }
}
