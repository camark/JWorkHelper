namespace DevLogHelper.Model
{
    /// <summary>
    /// 每一项对应的参数
    /// </summary>
    public class ExcelItem
    {
        /// <summary>
        /// 列名
        /// </summary>
        public string RowName { get; set; }
        /// <summary>
        /// 导出Excel数据类型
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 表格宽度
        /// </summary>
        public int With { get; set; }
        /// <summary>
        /// 映射关系
        /// </summary>
        public string Mapping { get; set; }
    }

    public class ListBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
