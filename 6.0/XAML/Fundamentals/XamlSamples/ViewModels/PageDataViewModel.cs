namespace XamlSamples
{
    public class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {

                // Part 5. From Data Bindings to MVVM
                new PageDataViewModel(typeof(OneShotDateTimePage), "Simple MVVM",
                                      "Obtain the current DateTime and display it"),

                new PageDataViewModel(typeof(HslColorScrollPage), "Interactive MVVM",
                                      "Use a view model to select HSL colors"),

                new PageDataViewModel(typeof(KeypadPage), "Commanding",
                                      "Use a view model for numeric keypad logic")
            };
        }

        public static IList<PageDataViewModel> All { private set; get; } 
    }
}
