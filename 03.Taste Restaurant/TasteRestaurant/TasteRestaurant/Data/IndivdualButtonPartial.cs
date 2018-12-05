namespace TasteRestaurant.Data
{
    public class IndivdualButtonPartial
    {
        public string Page { get; set; }

        public string Glyph { get; set; }

        public string ButtonType { get; set; }

        public int? Id { get; set; }
        
        public string ActionParameters
        {
            get
            {
                //if Id is deferent than0 and null we return the Id
                if (Id != 0 && Id != null) {
                    return Id.ToString();
                }

                return null;
            }
        }

    }
}
