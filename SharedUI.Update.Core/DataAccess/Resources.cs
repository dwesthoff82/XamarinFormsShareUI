using SQLite;

namespace SharedUI.Update.Core.DataAccess
{
    [Table("Resources")]
    public class Resources
    {
        [PrimaryKey, AutoIncrement, Column("resID")]
        public int resID { get; set; }//#violation

        public byte[] Data { get; set; }

        public string Text { get; set; }

    }
}
