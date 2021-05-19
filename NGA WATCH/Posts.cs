using System.Collections.Generic;

namespace NGA_WATCH
{
    public class CU
    {
        public int uid { get; set; }
        public int group_bit { get; set; }
        public string admincheck { get; set; }
        public int rvrc { get; set; }
    }

    public class GLOBAL
    {
        public string _ATTACH_BASE_VIEW { get; set; }
    }

    public class F
    {
        public string topped_topic { get; set; }
        public string sub_forums { get; set; }
    }


    public class P
    {
        public int tid { get; set; }
        public int pid { get; set; }
        public int authorid { get; set; }
        public int type { get; set; }
        public string postdate { get; set; }
        public string subject { get; set; }
        public string content { get; set; }
        public string icon { get; set; }
        public string comment_id { get; set; }
        public string js_escap_org_forum { get; set; }
        public string aid { get; set; }
        public string alterinfo { get; set; }
        public string attachs { get; set; }
        public string buy { get; set; }
        public int postdatetimestamp { get; set; }
        public int recommend { get; set; }
        public int org_fid { get; set; }
        public int denied { get; set; }
        public string hidden_content { get; set; }
        public string userip { get; set; }
        public string error { get; set; }
    }


    public class T
    {
        public int tid { get; set; }
        public int fid { get; set; }
        public int quote_from { get; set; }
        public string quote_to { get; set; }
        public string titlefont { get; set; }
        public string topic_misc { get; set; }
        public string author { get; set; }
        public int authorid { get; set; }
        public string subject { get; set; }
        public int type { get; set; }
        public int postdate { get; set; }
        public int lastpost { get; set; }
        public string lastposter { get; set; }
        public int replies { get; set; }
        public int lastmodify { get; set; }
        public int recommend { get; set; }
        public P __P { get; set; }
        public string tpcurl { get; set; }
        public int icon { get; set; }
        public string content { get; set; }
        public string ispage { get; set; }
        public int denied { get; set; }
        public string error { get; set; }
    }


    public class Data
    {
        public CU __CU { get; set; }
        public GLOBAL __GLOBAL { get; set; }
        public F __F { get; set; }
        public string __ROWS { get; set; }
        public Dictionary<int, T> __T { get; set; }
        public int __T__ROWS { get; set; }
        public int __T__ROWS_PAGE { get; set; }
        public int __R__ROWS_PAGE { get; set; }
    }

    public class Posts
    {
        public Data data { get; set; }
        public string encode { get; set; }
        public int time { get; set; }
    }
}