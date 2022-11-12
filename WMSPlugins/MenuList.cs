namespace WMSPlugins
{
    public class MenuList
    {
        public int Id { get; set; }
        public string? iconUrl { get; set; }
        public string title { get; set; }
        public string? href { get; set; }
        public string bakground { get; set; }
        public string fontColor { get; set; }
        public string Sidebarbackground { get; set; }


        public List<MenuList>? Items { get; set; }
    }
}

