using System;
using System.Collections.Generic;
using System.Text;

namespace EssensialWpfChapter6
{
    /// <summary>
    /// 機器の情報をビューに渡す構造体
    /// </summary>
    public struct MachineInfoStruct
    {
        ///<summary>Number</summary>
        public int Number { get; set; }

        ///<summary>Name</summary>
        public string Name { get; set; }

        ///<summary>Value</summary>
        public ushort Value { get; set; }

        ///<summary>コンストラクタ</summary>
        public MachineInfoStruct(int number, string name, ushort value)
        {
            Number = number;
            Name = name;
            Value = value;

        }

    }

    /// <summary>
    /// 機器の情報をビューに渡すクラス
    /// </summary>
    public class MachineInfoClass
    {
        ///<summary>Number</summary>
        public int Number { get; set; }

        ///<summary>Name</summary>
        public string Name { get; set; }

        ///<summary>Value</summary>
        public ushort Value { get; set; }

        ///<summary>コンストラクタ</summary>
        public MachineInfoClass(int number, string name, ushort value)
        {
            Number = number;
            Name = name;
            Value = value;

        }

        ///<summary>コンストラクタ</summary>
        public MachineInfoClass()
        {

        }

    }
}
