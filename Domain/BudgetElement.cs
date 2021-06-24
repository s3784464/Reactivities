using System;

namespace Domain
{
    public class BudgetElement
    {
        public Guid Element_Id { get; set; }
        public Guid User_Id { get; set; }
        public bool IsIncome { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Value { get; set; }
        public string Frequency { get; set; }
    }
}