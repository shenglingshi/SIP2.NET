using SIP2.Core;
using SIP2.Core.Command;
using SIP2.Field;
using SIP2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIP2.Response
{
    /// <summary>
    /// 基础响应
    /// </summary>
    public abstract class BaseResponseCommand : BaseCommand
    {
        public BaseResponseCommand() { }

        public BaseResponseCommand(string command)
        {
            this._command = command;
        }

        public virtual void Parse()
        {
            this._identifier = this._command.Substring(0, 2);

            if (this.CommandFields != null)
            {
                int position = 3;
                foreach (var item in this.CommandFields)
                {
                    //是否定义映射的属性
                    if (!string.IsNullOrEmpty(item.Name))
                    {
                        //是否是必选的字段
                        if (!item.IsRequired)
                        {
                            //是否存在必选值
                            if (!this.Command.Contains(item.ID))
                            {
                                continue;
                            }
                        }else if(!string.IsNullOrEmpty(item.ID) && !this.Command.Contains(item.ID))
                        {
                            throw new ParameterException($"can not find property {item.Name} value");
                        }
                        var property = this.GetType().GetProperties().SingleOrDefault(p => p.Name.Equals(item.Name, StringComparison.CurrentCultureIgnoreCase));// .GetProperty(item.Name,System.Reflection.BindingFlags.IgnoreCase);
                        if (property != null)
                        {
                            string fieldValueSegment = string.Empty;
                            if (item.IsFixed)
                            {
                                fieldValueSegment = GetFixedLengthFieldValue(position, item.FixedLength);
                            }
                            else
                            {
                                fieldValueSegment = GetVariableLengthFieldValue(position, item.Split);
                            }

                            if(!string.IsNullOrEmpty(fieldValueSegment))
                            {
                                string fieldValue = fieldValueSegment;                   
                                if (!string.IsNullOrEmpty(item.ID))
                                {
                                    fieldValue = fieldValueSegment.Replace(item.ID, "").Replace(item.Split,"");
                                }
                                //解析获取到的值
                                if (property.PropertyType == typeof(int))
                                {
                                    property.SetValue(this, Convert.ToInt32(fieldValue));
                                }
                                else if (property.PropertyType == typeof(DateTime))
                                {
                                    property.SetValue(this, CommandUtil.GetDate(fieldValue));
                                }
                                else if (property.PropertyType == typeof(bool))
                                {
                                    property.SetValue(this, CommandUtil.GetBooleanValue(fieldValue));
                                }
                                else if (property.PropertyType == typeof(char))
                                {
                                    property.SetValue(this, fieldValue[0]);
                                }
                                else if(property.PropertyType ==  typeof(string))
                                {
                                    property.SetValue(this, fieldValue);
                                }

                                position += fieldValueSegment.Length;
                            }
                        }
                    }
                }
            }
        }

        public void Parse(string command)
        {
            this._command = command;
            this.Parse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start">下标从1开始</param>
        /// <param name="length"></param>
        /// <returns></returns>
        protected virtual string GetFixedLengthFieldValue(int start,int length)
        {
            return this._command.Substring(start - 1, length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start">下标从1开始</param>
        /// <param name="split"></param>
        /// <returns></returns>
        public virtual string GetVariableLengthFieldValue(int start,string split)
        {
            var startIndex = start - 1;
            var lastIndex = this._command.IndexOf(split, startIndex);
            var subString = this._command.Substring(startIndex, lastIndex+1- startIndex);
            return subString;
        }

    }
}
