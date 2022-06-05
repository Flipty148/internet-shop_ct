namespace internet_shop_ct.Models
{
    public class Promo
    {
        public int Id_promos { get; private set; } //ID акции

        public string Name { get; private set; } //Название акции

        public string? Description { get; private set; } //Описание

        public string Promo_conditions { get; private set; } //Условия

        public DateOnly Start_date { get; private set; } //Дата начала

        public DateOnly End_date { get; private set; } //Дата окончания

        public float Promo_percent { get; private set; } //Размер акции в диапозоне [0;1]

        public Promo(int id_promos, string name, string description, string promo_conditions, DateOnly start_date, DateOnly end_date, float promo_percent)
        {
            Id_promos = id_promos;
            Name = name;
            Description = description;
            Promo_conditions = promo_conditions;
            Start_date = start_date;
            End_date = end_date;
            Promo_percent = promo_percent;
        }

        public Promo(int id_promos, string name, string promo_conditions, DateOnly start_date, DateOnly end_date, float promo_percent)
        {
            Id_promos = id_promos;
            Name = name;
            Promo_conditions = promo_conditions;
            Start_date = start_date;
            End_date = end_date;
            Promo_percent = promo_percent;
        }
    }
}
