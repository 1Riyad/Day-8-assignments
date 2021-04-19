using System;

namespace week2_day1_exercise1
{
    class JsonBuilder
    {
        private string json;

        public JsonBuilder()
        {
            this.json = "";
        }

        public JsonBuilder openBracket()
        {
            this.json += "{\n";
            return this;
        }

        public JsonBuilder closeBracket()
        {
            // deal with last comma added by setValue()
            if (this.json[this.json.Length - 2] == ',')
                this.json = this.json.Remove(this.json.Length - 2);
            this.json += "\n}";
            return this;
        }
        public JsonBuilder setKey(string key)
        {
            this.json += $"\"{key}\": ";
            return this;
        }
        public JsonBuilder setValue(string value)
        {
            if (Int32.TryParse(value, out int result))
                this.json += $"{result},\n";
            else if (Boolean.TryParse(value, out bool result_bool))
                this.json += $"{result_bool},\n";
            else
                this.json += $"\"{value}\",\n";
            return this;
        }
        public string getJson()
        {
            return this.json;

        }

        static void Main(string[] args)
        {
            JsonBuilder j = new JsonBuilder();
            string returned_json = j.openBracket()
                                    .setKey("Id").setValue("1Riyad")
                                    .setKey("Name").setValue("Riyad Alghamdi")
                                    .setKey("Bootcamp").setValue("Tuwaiq for programming")
                                    .setKey("Bootcamp version").setValue("3")
                                    .setKey("Path").setValue(".Net")
                                    .setKey("Still going").setValue("true")
                                    .closeBracket()
                                    .getJson();

            Console.WriteLine(returned_json);
        }
    }
}