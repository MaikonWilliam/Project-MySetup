namespace MyPc.Models
{
    public class SetupModel
    {
        public int Id { get; set; }
        public string NameSetup { get; set; }
        public string Cpu { get; set; }
        public string Motherboard { get; set; }
        public string? Gpu { get; set; }
        public string RAM { get; set; }
        public string SSD_or_HD { get; set; }
        public string PowerSupply { get; set; }
        public string? Cabinet { get; set; }
        public double? TotalPrice { get; set; }
    }
}
