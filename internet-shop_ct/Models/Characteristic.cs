namespace internet_shop_ct.Models
{
    public class Characteristic
    {
        public int Id { get; private set; } //ID характеристики

        public string Name { get; private set; } //Название характеристики

        public string? Description { get; private set; } //Описание

        public string Value { get; private set; } //Значение

        public Characteristic(int id, string name, string description, string value)
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
        }

        public Characteristic(int id, string name, string value)
        {
            Id = id;
            Name = name;
            Value = value;
        }

        public Characteristic(string name, string description, string value)
        {
            Name = name;
            Description = description;
            Value = value;
        }

        public Characteristic(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
