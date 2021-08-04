namespace YSCloud.Gainscha.CloudPrinter
{
    /// <summary>
    /// 打印机状态
    /// </summary>
    public enum CloudPrinterStatus
    {
        /// <summary>
        /// 上线
        /// </summary>
        Online = 0,

        /// <summary>
        /// 正常
        /// </summary>
        Normal = 1,

        /// <summary>
        /// 缺纸
        /// </summary>
        NoPaper = 2,

        /// <summary>
        /// 其他异常
        /// </summary>
        Error = 3,

        /// <summary>
        /// 过热
        /// </summary>
        Overheat = 4,

        /// <summary>
        /// 开盖
        /// </summary>
        Uncapped = 5,

        /// <summary>
        /// 暂停
        /// </summary>
        Paused = 8,

        /// <summary>
        /// 打印中
        /// </summary>
        Printing = 9
    }
}
