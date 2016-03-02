using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExpress
{
    class Common
    {
        static public string GetExpressCompanyNO(string name)
        {
            string typeCom = name;
            if (typeCom == "AAE全球专递")
            {
                typeCom = "aae";
            }
            if (typeCom == "安捷快递")
            {
                typeCom = "anjiekuaidi";
            }
            if (typeCom == "安信达快递")
            {
                typeCom = "anxindakuaixi";
            }
            if (typeCom == "百福东方")
            {
                typeCom = "baifudongfang";
            }
            if (typeCom == "彪记快递")
            {
                typeCom = "biaojikuaidi";
            }
            if (typeCom == "BHT")
            {
                typeCom = "bht";
            }
            if (typeCom == "BHT")
            {
                typeCom = "bht";
            }
            if (typeCom == "希伊艾斯快递")
            {
                typeCom = "cces";
            }
            if (typeCom == "中国东方")
            {
                typeCom = "Coe";
            }
            if (typeCom == "长宇物流")
            {
                typeCom = "changyuwuliu";
            }
            if (typeCom == "大田物流")
            {
                typeCom = "datianwuliu";
            }
            if (typeCom == "德邦物流")
            {
                typeCom = "debangwuliu";
            }
            if (typeCom == "DPEX")
            {
                typeCom = "dpex";
            }
            if (typeCom == "DHL")
            {
                typeCom = "dhl";
            }
            if (typeCom == "D速快递")
            {
                typeCom = "dsukuaidi";
            }
            if (typeCom == "fedex")
            {
                typeCom = "fedex";
            }
            if (typeCom == "飞康达物流")
            {
                typeCom = "feikangda";
            }
            if (typeCom == "凤凰快递")
            {
                typeCom = "fenghuangkuaidi";
            }
            if (typeCom == "港中能达物流")
            {
                typeCom = "ganzhongnengda";
            }
            if (typeCom == "广东邮政物流")
            {
                typeCom = "guangdongyouzhengwuliu";
            }
            if (typeCom == "汇通快运")
            {
                typeCom = "huitongkuaidi";
            }
            if (typeCom == "恒路物流")
            {
                typeCom = "hengluwuliu";
            }
            if (typeCom == "华夏龙物流")
            {
                typeCom = "huaxialongwuliu";
            }
            if (typeCom == "佳怡物流")
            {
                typeCom = "jiayiwuliu";
            }
            if (typeCom == "京广速递")
            {
                typeCom = "jinguangsudikuaijian";
            }
            if (typeCom == "急先达")
            {
                typeCom = "jixianda";
            }
            if (typeCom == "佳吉物流")
            {
                typeCom = "jiajiwuliu";
            }
            if (typeCom == "加运美")
            {
                typeCom = "jiayunmeiwuliu";
            }
            if (typeCom == "快捷速递")
            {
                typeCom = "kuaijiesudi";
            }
            if (typeCom == "联昊通物流")
            {
                typeCom = "lianhaowuliu";
            }
            if (typeCom == "龙邦物流")
            {
                typeCom = "longbanwuliu";
            }
            if (typeCom == "民航快递")
            {
                typeCom = "minghangkuaidi";
            }
            if (typeCom == "配思货运")
            {
                typeCom = "peisihuoyunkuaidi";
            }
            if (typeCom == "全晨快递")
            {
                typeCom = "quanchenkuaidi";
            }
            if (typeCom == "全际通物流")
            {
                typeCom = "quanjitong";
            }
            if (typeCom == "全日通快递")
            {
                typeCom = "quanritongkuaidi";
            }
            if (typeCom == "全一快递")
            {
                typeCom = "quanyikuaidi";
            }
            if (typeCom == "盛辉物流")
            {
                typeCom = "shenghuiwuliu";
            }
            if (typeCom == "速尔物流")
            {
                typeCom = "suer";
            }
            if (typeCom == "盛丰物流")
            {
                typeCom = "shengfengwuliu";
            }
            if (typeCom == "天地华宇")
            {
                typeCom = "tiandihuayu";
            }
            if (typeCom == "天天快递")
            {
                typeCom = "tiantian";
            }
            if (typeCom == "TNT")
            {
                typeCom = "tnt";
            }
            if (typeCom == "UPS")
            {
                typeCom = "ups";
            }
            if (typeCom == "万家物流")
            {
                typeCom = "wanjiawuliu";
            }
            if (typeCom == "文捷航空速递")
            {
                typeCom = "wenjiesudi";
            }
            if (typeCom == "伍圆速递")
            {
                typeCom = "wuyuansudi";
            }
            if (typeCom == "万象物流")
            {
                typeCom = "wanxiangwuliu";
            }
            if (typeCom == "新邦物流")
            {
                typeCom = "xinbangwuliu";
            }
            if (typeCom == "信丰物流")
            {
                typeCom = "xinfengwuliu";
            }
            if (typeCom == "星晨急便")
            {
                typeCom = "xingchengjibian";
            }
            if (typeCom == "鑫飞鸿物流")
            {
                typeCom = "xinhongyukuaidi";
            }
            if (typeCom == "亚风速递")
            {
                typeCom = "yafengsudi";
            }
            if (typeCom == "一邦速递")
            {
                typeCom = "yibangwuliu";
            }
            if (typeCom == "优速物流")
            {
                typeCom = "youshuwuliu";
            }
            if (typeCom == "远成物流")
            {
                typeCom = "yuanchengwuliu";
            }
            if (typeCom == "圆通速递")
            {
                typeCom = "yuantong";
            }
            if (typeCom == "源伟丰快递")
            {
                typeCom = "yuanweifeng";
            }
            if (typeCom == "元智捷诚快递")
            {
                typeCom = "yuanzhijiecheng";
            }
            if (typeCom == "越丰物流")
            {
                typeCom = "yuefengwuliu";
            }
            if (typeCom == "韵达快递")
            {
                typeCom = "yunda";
            }
            if (typeCom == "源安达")
            {
                typeCom = "yuananda";
            }
            if (typeCom == "运通快递")
            {
                typeCom = "yuntongkuaidi";
            }
            if (typeCom == "宅急送")
            {
                typeCom = "zhaijisong";
            }
            if (typeCom == "中铁快运")
            {
                typeCom = "zhongtiewuliu";
            }
            if (typeCom == "中通速递")
            {
                typeCom = "zhongtong";
            }
            if (typeCom == "中邮物流")
            {
                typeCom = "zhongyouwuliu";
            }
            return typeCom;
        }


        static public string[,] GetExpressCompany()
        {
            //string[][] typeCom=new string[74,2];
            string typeCom = "";
            typeCom += "AAE全球专递:aae";
            typeCom += "|AAE安捷快递:anjiekuaidi";
            typeCom += "|安信达快递:anxindakuaixi";

            typeCom += "|百福东方:baifudongfang";
            typeCom += "|彪记快递:biaojikuaidi";
            typeCom += "|BHT:bht";

            typeCom += "|希伊艾斯快递:cces";
            typeCom += "|中国东方:Coe";
            typeCom += "|长宇物流:changyuwuliu";

            typeCom += "|大田物流:datianwuliu";
            typeCom += "|德邦物流:debangwuliu";
            typeCom += "|DPEX:dpex";
            typeCom += "|DHL:dhl";
            typeCom += "|D速快递:dsukuaidi";

            typeCom += "|EMS特快专递:ems";

            typeCom += "|fedex:fedex";
            typeCom += "|飞康达物流:feikangda";
            typeCom += "|凤凰快递:fenghuangkuaidi";

            typeCom += "|港中能达物流:ganzhongnengda";
            typeCom += "|广东邮政物流:guangdongyouzhengwuliu";
            typeCom += "|GLS快递:gls";

            typeCom += "|汇通快运:huitongkuaidi";
            typeCom += "|恒路物流:hengluwuliu";
            typeCom += "|华夏龙物流:huaxialongwuliu";

            typeCom += "|佳怡物流:jiayiwuliu";
            typeCom += "|京广速递:jinguangsudikuaijian";
            typeCom += "|急先达:jixianda";
            typeCom += "|佳吉物流:jiajiwuliu";
            typeCom += "|加运美:jiayunmeiwuliu";

            typeCom += "|快捷速递:kuaijiesudi";

            typeCom += "|联昊通物流:lianhaowuliu";
            typeCom += "|龙邦物流:longbanwuliu";
            typeCom += "|蓝镖快递:lanbiaokuaidi";

            typeCom += "|民航快递:minghangkuaidi";

            typeCom += "|配思货运:peisihuoyunkuaidi";

            typeCom += "|全晨快递:quanchenkuaidi";
            typeCom += "|全际通物流:quanjitong";
            typeCom += "|全日通快递:quanritongkuaidi";
            typeCom += "|全一快递:quanyikuaidi";

            typeCom += "|申通快递:shentong";
            typeCom += "|顺丰速运:shunfeng";
            typeCom += "|上大物流:shangda";
            typeCom += "|盛辉物流:shenghuiwuliu";
            typeCom += "|速尔物流:suer";
            typeCom += "|盛丰物流:shengfengwuliu";

            typeCom += "|天地华宇:tiandihuayu";
            typeCom += "|天天快递:tiantian";
            typeCom += "|TNT:tnt";

            typeCom += "|UPS:ups";

            typeCom += "|万家物流:wanjiawuliu";
            typeCom += "|文捷航空速递:wenjiesudi";
            typeCom += "|伍圆速递:wuyuansudi";
            typeCom += "|万象物流:wanxiangwuliu";

            typeCom += "|新邦物流:xinbangwuliu";
            typeCom += "|信丰物流:xinfengwuliu";
            typeCom += "|星晨急便:xingchengjibian";
            typeCom += "|鑫飞鸿物流:xinhongyukuaidi";

            typeCom += "|亚风速递:yafengsudi";
            typeCom += "|一邦速递:yibangwuliu";
            typeCom += "|优速物流:youshuwuliu";
            typeCom += "|远成物流:yuanchengwuliu";
            typeCom += "|圆通速递:yuantong";
            typeCom += "|源伟丰快递:yuanweifeng";
            typeCom += "|元智捷诚快递:yuanzhijiecheng";
            typeCom += "|越丰物流:yuefengwuliu";
            typeCom += "|韵达快递:yunda";
            typeCom += "|源安达:yuananda";
            typeCom += "|原飞航物流:yuanfeihangwuliu";
            typeCom += "|运通快递:yuntongkuaidi";

            typeCom += "|宅急送:zhaijisong";
            typeCom += "|中铁快运:zhongtiewuliu";
            typeCom += "|中通速递:zhongtong";
            typeCom += "|中邮物流:zhongyouwuliu";

            string[] typeCom1 = typeCom.Split('|');
            string[,] typeCom11 = new string[typeCom1.Length, 2];
            for (int i = 0; i < typeCom1.Length; i++)
            {
                typeCom11[i, 0] = typeCom1[i].Split(':')[0];
                typeCom11[i, 1] = typeCom1[i].Split(':')[1];
            }

            return typeCom11;

        }
    }
}
