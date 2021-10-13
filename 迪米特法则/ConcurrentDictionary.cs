using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迪米特法则
{
    /// <summary>
    /// 通用字典类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConcurrentDictionary<T> : IConcurrentDictionary<T>
    {
        #region Fields

        /// <summary>
        /// 数据同步字典
        /// </summary>
        private readonly ConcurrentDictionary<string, T> m_dictionary = new ConcurrentDictionary<string, T>();

        #endregion

        #region Constructors

        private ConcurrentDictionary() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dictionaryName"></param>
        public ConcurrentDictionary(string dictionaryName)
        {
            Name = dictionaryName;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 字典名称
        /// </summary>
        public string Name { get; }

        #endregion

        #region Public Methods

        public int Count => m_dictionary.Count;


        /// <summary>
        /// 增
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void TryAdd(string key, T value)
        {
            m_dictionary.TryAdd(key, value);
        }

        /// <summary>
        /// 增或修改
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void TryAddOrUpdate(string key, T value)
        {
            TryRemove(key);
            TryAdd(key, value);
        }

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="key"></param>
        public void TryRemove(string key)
        {
            m_dictionary.TryRemove(key, out _);
        }

        /// <summary>
        /// 查
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public T TryGetValue(string key)
        {
            T value = default(T);
            m_dictionary.TryGetValue(key, out value);

            return value;
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public List<T> TryGetValues()
        {
            return m_dictionary.Values.ToList();
        }

        /// <summary>
        /// 是否存在Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Exist(string key)
        {
            return m_dictionary.Any(item => item.Key == key);
        }

        /// <summary>
        /// 获取字典所有Keys
        /// </summary>
        /// <returns></returns>
        public List<string> TryGetKeys()
        {

            return m_dictionary.Keys.ToList();
        }

        /// <summary>
        /// 获取字典所有
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<string, T>> TryGetAll()
        {
            return m_dictionary.ToList();
        }

        #endregion
    }

    /// <summary>
    /// 通用字典类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IConcurrentDictionary<T>
    {
        /// <summary>
        /// 集合数量
        /// </summary>
        /// <returns></returns>
        int Count { get; }

        /// <summary>
        /// 增
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void TryAdd(string key, T value);

        /// <summary>
        /// 增或修改
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void TryAddOrUpdate(string key, T value);

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="key"></param>
        void TryRemove(string key);

        /// <summary>
        /// 查
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        T TryGetValue(string key);

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        List<T> TryGetValues();

        /// <summary>
        /// 是否存在Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Exist(string key);

        /// <summary>
        /// 获取字典所有Keys
        /// </summary>
        /// <returns></returns>
        List<string> TryGetKeys();

        /// <summary>
        /// 获取字典所有
        /// </summary>
        /// <returns></returns>
        List<KeyValuePair<string, T>> TryGetAll();

    }
}
