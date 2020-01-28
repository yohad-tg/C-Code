using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleHit
{
    enum Brand
    {
        CommonSites = 1949800, // must of the sites 
        FemBrand = 102848897, // femau / femde / femfr / femuk
        OalBrand = 113243828,
        IBBrand = 192385 
    }
    enum Sites
    {
        AU = 18,
        BR = 20,
        CA = 17,
        CH = 15,
        DE = 7,
        DEV = 56,
        DK = 35,
        ES = 3,
        FEMAU = 6,
        FEMDE = 3,
        FEMFR = 4,
        FEMUK = 2,
        FEMUS = 54,
        FI = 42,
        FR = 2,
        IB = 1,
        IE = 26,
        IL = 45,
        IN = 57,
        IT = 6,
        JP = 5,
        KR = 58,
        MX = 44,
        NL = 22,
        NO = 19,
        NZ = 31,
        OAL = 1,
        PL = 30,
        PT = 50,
        RU = 51,
        SE = 10,
        SG = 41,
        TK = 411, // Same as SG 
        UK = 9,
        US = 1,
        ZA = 59


    }

    class UrlHandler
    {

        private string UrlHit = "";
        public string GaTid
        {
            get { return GaTid; }
            set { GaTid = value; }
        }

        //Spliter = return the value of the brand
        public int BrandSpliter(string GaTid)
        {
            string[] Tid = GaTid.Split('-');
            return int.Parse(Tid[1]);
        }
        //SiteSpliter split the site number from Gatid.
        public int SiteSpliter(string GaTid)
        {
            string[] Tid = GaTid.Split('-');
            return int.Parse(Tid[2]);
        }

        public string UrlCreator(string GaTid,string Cid,string ShippingName,string Orderdate,string TotalOrders, string Ltv,string gender)
        {
            //IB
            if ((int)Brand.IBBrand == BrandSpliter(GaTid))
            {
                return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid,ShippingName,Orderdate, TotalOrders, Ltv,gender);

                
            }

            //OAL
            if ((int)Brand.OalBrand == BrandSpliter(GaTid))
            {
                return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);
            }
            
            //FEMS 
            if ((int)Brand.FemBrand == BrandSpliter(GaTid))
            {
                switch (SiteSpliter(GaTid))
                {
                    case (int)Sites.FEMAU:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.FEMDE:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.FEMFR:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.FEMUK:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    default:
                        throw new InvalidOperationException("Unknown GaTid type");
                }
            }


            //Common Sites
            if ((int)Brand.CommonSites == BrandSpliter(GaTid))
            {
                switch (SiteSpliter(GaTid))
                {
                    case (int)Sites.AU:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd21={2}&cd22={3}&cd23={4}&cd24={5}&cd25={6}&ni=1", GaTid, Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.BR:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid,Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.CA:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.CH:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd22={2}&cd23={3}&cd24={4}&cd25={5}&cd26={6}&ni=1", GaTid, Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.DE:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.DEV:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.DK:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.ES:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.FEMUS:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd4={2}&cd5={3}&cd6={4}&cd7={5}&cd8={6}&ni=1", GaTid, Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.FI:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.FR:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.IE:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd8={2}&cd9={3}&cd10={4}&cd11={5}&cd12={6}&ni=1", GaTid, Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.IL:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd5={2}&cd6={3}&cd7={4}&cd8={5}&cd9={6}&ni=1", GaTid, Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.IN:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.IT:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);
                        
                    case (int)Sites.JP:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.KR:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.MX:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.NL:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.NO:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.NZ:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd6={2}&cd7={3}&cd8={4}&cd9={5}&cd10={6}&ni=1", GaTid, Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.PL:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd5={2}&cd6={3}&cd7={4}&cd8={5}&cd9={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.PT:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd5={2}&cd6={3}&cd7={4}&cd8={5}&cd9={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.RU:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd5={2}&cd6={3}&cd7={4}&cd8={5}&cd9={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.SE:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.SG:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd5={2}&cd6={3}&cd7={4}&cd8={5}&cd9={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.TK://same as SG 
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd5={2}&cd6={3}&cd7={4}&cd8={5}&cd9={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.UK:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd18={2}&cd19={3}&cd20={4}&cd21={5}&cd22={6}&ni=1", GaTid, Cid,ShippingName,Orderdate,TotalOrders,Ltv,gender);

                    case (int)Sites.US:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd17={2}&cd18={3}&cd19={4}&cd20={5}&cd21={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);

                    case (int)Sites.ZA:
                        return UrlHit = string.Format("v=1&t=event&tid={0}&cid={1}&ec=crm&ea=enrichment&cd2={2}&cd3={3}&cd4={4}&cd5={5}&cd6={6}&ni=1", GaTid, Cid, ShippingName, Orderdate, TotalOrders, Ltv, gender);
                    default:
                        throw new InvalidOperationException("Unknown GaTid type");
                }
            }
            return UrlHit;

        }
    }
}
