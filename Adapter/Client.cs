namespace Adapter
{
    class Client
    {
        ISalaryBonus _bonusSal;
        public Client(ISalaryBonus bonusSal)
        {
            _bonusSal = bonusSal;
        }

        public int CalculateSalaryBonus(Employee employee)
        {
            return _bonusSal.CalculateSalaryBonus(employee);
        }
    }
}
