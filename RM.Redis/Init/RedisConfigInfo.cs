using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Redis.Init
{
    public sealed class RedisConfigInfo
    {
        public string WriteServerList = "127.0.0.1:6379";

        public string ReadServerList = "127.0.0.1:6379";

        /// <summary>
        /// 最大写连接数
        /// </summary>
        public int MaxWritePoolSize = 60;

        /// <summary>
        /// 最大读连接数
        /// </summary>
        public int MaxReadPoolSize = 60;

        /// <summary>
        /// 本地缓存到期时间，单位：秒
        /// </summary>
        public int LocalCacheTime = 180;

        public bool AutoStart = true;

        /// <summary>
        /// 是否记录日志，该设置仅用于排查Redis运行时出现的问题
        /// 如redis正常工作，请关闭该项
        /// </summary>
        public bool RecordLog = false;
    }
}
