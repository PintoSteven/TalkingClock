namespace TalkingClock
{
    public class ConvertTimeToWords
    {
        private readonly string[] hours = { "twelve", "one", "two", "three", "four",
                            "five", "six", "seven", "eight", "nine",
                            "ten", "eleven"};
        private readonly string[] minutes = { "", "one", "two", "three", "four",
                            "five", "six", "seven", "eight", "nine",
                            "ten", "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twenty","half"};
        private const int TotalMinutes = 60;
        public string ConvertToWords(int hour, int minute)
        {
            string result = string.Empty;
            var text = minute > 30 ? "to" : "past";
            hour = minute > 30 ? (hour + 1) : hour;
            if (minute == 0)
            {
                result = $"{hours[hour % 12]} o'clock";
            }
            else
            {
                result = $"{ConvertMinute(minute).Trim()} {text} {hours[hour % 12]}";
            }
            result = result.Trim();
            return $"{result.First().ToString().ToUpper()}{String.Join("", result.Skip(1))}";
        }

        private string ConvertMinute(int minute)
        {
            minute = minute > 30 ? TotalMinutes - minute : minute;
            var remainder = minute < 21 ? minute : minute % 10;
            return $"{minutes[(minute == 30 ? minute - 9 : minute) - remainder]} {minutes[remainder]}";
        }
    }
}
