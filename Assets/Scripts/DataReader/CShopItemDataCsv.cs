﻿using System;using System.Collections.Generic;/// <summary>/// 商城商品数据/// </summary>  public class ShopItemdata{    public uint ItemID;                      //商品ID        public Shop.SHOPTYPE BelongShopType;     //所属商城类型    public Shop.ITEMTYPE ItemType;           //购买得到的商品类型    public string ItemIcon;                  //商品icon名称    public string ItemName;                  //商品名称    public uint ItemNum;                     //购买得到的商品数量    public uint PresentItemNum;              //购买后赠送的数量    public uint ItemPrice;                   //商品价格    public Shop.CURRENCYTYPE CurrencyType;   //所需货币类型    public uint SpecilSign;                  //特殊标记};/// <summary>/// 商城商品数据管理/// </summary>public class CShopItemDataMgr{    private Dictionary<uint, ShopItemdata> ShopItemDataDictionary;    private Dictionary<int,List<uint>> ShopKindsItemList;    //private List<string[]> allArrary;    public CShopItemDataMgr()    {        ShopKindsItemList = new Dictionary<int, List<uint>>();        ShopItemDataDictionary = new Dictionary<uint, ShopItemdata>();    }    /// <summary>    /// 读取商品表    /// </summary>    public void LoadShopItemDataFile()    {        List<string[]> strList;        CReadCsvBase.ReaderCsvDataFromAB(GameDefine.CsvAssetbundleName, GameDefine.ShopCsvFileName, out strList);        int columnCount = strList.Count;        for (int i = 2; i < columnCount; i++)        {            ShopItemdata itemData = new ShopItemdata();            uint.TryParse(strList[i][0], out itemData.ItemID);            byte type;            byte.TryParse(strList[i][1], out type);            itemData.BelongShopType = (Shop.SHOPTYPE)type;            byte.TryParse(strList[i][2], out type);            itemData.ItemType = (Shop.ITEMTYPE)type;            itemData.ItemIcon = strList[i][3];            itemData.ItemName = strList[i][4];            uint.TryParse(strList[i][5],out itemData.ItemNum);            uint.TryParse(strList[i][6], out itemData.PresentItemNum);            uint.TryParse(strList[i][7], out itemData.ItemPrice);            byte.TryParse(strList[i][8], out type);            itemData.CurrencyType = (Shop.CURRENCYTYPE)type;            uint.TryParse(strList[i][9], out itemData.SpecilSign);            int shoptype = (int)(itemData.BelongShopType);            if (!ShopKindsItemList.ContainsKey(shoptype))            {                ShopKindsItemList.Add(shoptype,new List<uint>());            }            ShopKindsItemList[shoptype].Add(itemData.ItemID);            ShopItemDataDictionary.Add(itemData.ItemID, itemData);        }            }   /// <summary>   /// 获取商品数据data   /// </summary>   /// <param name="itemId"></param>   /// <returns></returns>    public ShopItemdata GetShopItemData(uint  itemId)    {        if (ShopItemDataDictionary.ContainsKey(itemId))            return ShopItemDataDictionary[itemId];        return null;    }    //按商店类型获取商品list    public List<uint> GetShopItemListByType(Shop.SHOPTYPE shoptype)    {        int type = (int)shoptype;        if(ShopKindsItemList.ContainsKey(type))        {            return ShopKindsItemList[type];        }        return new List<uint>();    }}