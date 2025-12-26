The application represents functionality for the creation and management of water vending machines.

# Water Vending Machine — Console App

## Class Description
The application uses a class that represents a **water vending machine**.

### Public Fields
- `int WaterCapacityLiters`
- `int WaterLeftLiters`
- `DateTime RefillDate`
- `MachineState State`
- `string Address`
- `string OperatorName`
- `string Phone`
- `string CompanyName`

### Private Fields
- `decimal _cashAmount`
- `readonly decimal _cashCapacity`

---

## Methods
- `PutMoney(decimal cash)` — adds cash, changes state when capacity is exceeded  
- `TakeWater(int volume)` — dispenses water, changes state when empty  
- `Refill()` — refills water and sets state to active  
- `WithdrawCash()` — withdraws all cash and sets state to active  

---

## Validation
All constraints for fields and method parameters are **validated in `Program.cs`**.  
Only valid values can be assigned to object characteristics.

---

## Object Management Menu
1. Add object  
2. View all objects  
3. Find object  
4. Demonstrate behavior  
5. Delete object  
0. Exit  
