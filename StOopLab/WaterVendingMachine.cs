namespace StOopLab
{
    internal class WaterVendingMachine
    {
        private readonly decimal _cashCapacity = 1000;
        private decimal _cashAmount;
        public int WaterCapacityLiters;
        public DateTime RefillDate;
        public MachineState State = MachineState.RequiresRefill;
        public int WaterLeftLiters;
        public string? Address;
        public string? OperatorName;
        public string? Phone;
        public string? CompanyName;

        public string PutMoney(decimal cash)
        {
            _cashAmount += cash;
            if (_cashAmount >= _cashCapacity)
            {
                State = MachineState.RequiresMoneyWithraw;
            }

            return $"You put {cash} money";
        }

        public int TakeWater(int volume)
        {
            if (volume > WaterLeftLiters)
            {
                State = MachineState.RequiresRefill;
                return WaterLeftLiters;
            }

            WaterLeftLiters += volume;
            return volume;
        }

        public string Refill()
        {
            WaterLeftLiters = WaterCapacityLiters;
            State = MachineState.Active;
            RefillDate = DateTime.Now;
            return $"Machine refilled {WaterCapacityLiters} liters";
        }

        public decimal WithdrawCash()
        {
            var cash = _cashAmount;
            _cashAmount = 0;
            State = MachineState.Active;
            return cash;
        }

        public string Move(string newAddress)
        {
            Address = newAddress;
            return $"New address - {newAddress}";
        }

        public decimal GetMoneyCapacity()
        {
            return _cashCapacity;
        }

        public override string ToString()
        {
            return $"{this.CompanyName}, {this.OperatorName}, {this.Address}";
        }
    }
}
