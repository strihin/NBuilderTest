namespace PencilJoyTests.Data
{
    class CreateBookData
    {
        public string Username { get; set; }
        public int NumberMonth { get; set; }
        public int NumberDay { get; set; }
        private string SelectorForCharacterPerson { get; set; }
        private int numberSex;
        public int NumberSex
        {
            get
            {
                return numberSex;
            }
            set
            {
                switch (value)
                {
                    case 0:
                        numberSex = 2;
                        SelectorForCharacterPerson = "#select-girl";
                        break;

                    case 1:
                        numberSex = 1;
                        SelectorForCharacterPerson = "#select-boy";
                        break;

                    default:
                        numberSex = -1;
                        break;
                }
            }
        }
        public int NumberCharacter { get; set; }

        public CreateBookData() { }
        public CreateBookData(string username, int numberMonth, int numberDay, int numberSex, int numberCharacter)
        {
            Username = username;
            NumberMonth = numberMonth;
            NumberDay = numberDay;
            NumberSex = numberSex;
            NumberCharacter = numberCharacter;
        }
    }
}
