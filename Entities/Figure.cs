namespace FunkoApi.Entities
{
    public class Figure
    {
        public string Id { get; set; }
        public string Handle { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string Series { get; set; }

        public Figure(string Id, string Handle, string Title, string ImageName, string Series)
        {
            this.Id = Id;
            this.Handle = Handle;
            this.Title = Title;
            this.ImageName = ImageName;
            this.Series = Series;
        }
    }
}
