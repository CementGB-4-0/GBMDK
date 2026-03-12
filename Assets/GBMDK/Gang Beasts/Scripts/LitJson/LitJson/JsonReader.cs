using System.Collections.Generic;
using System.IO;

namespace LitJson
{
    public class JsonReader
    {
        private static IDictionary<int, IDictionary<int, int[]>> parse_table;

        private Stack<int> automaton_stack;

        private int current_input;

        private int current_symbol;

        private bool end_of_input;

        private bool end_of_json;

        private Lexer lexer;

        private bool parser_in_string;

        private bool parser_return;

        private bool read_started;

        private TextReader reader;

        private bool reader_is_owned;

        private bool skip_non_members;

        private JsonToken token;

        private object token_value;

        static JsonReader()
        {
        }

        public JsonReader(string json_text)
        {
        }

        private JsonReader(TextReader reader, bool owned)
        {
        }

        public bool SkipNonMembers => false;

        public JsonToken Token => default(JsonToken);

        public object Value => null;

        private static void PopulateParseTable()
        {
        }

        private static void TableAddCol(ParserToken row, int col, params int[] symbols)
        {
        }

        private static void TableAddRow(ParserToken rule)
        {
        }

        private void ProcessNumber(string number)
        {
        }

        private void ProcessSymbol()
        {
        }

        private bool ReadToken()
        {
            return false;
        }

        public void Close()
        {
        }

        public bool Read()
        {
            return false;
        }
    }
}