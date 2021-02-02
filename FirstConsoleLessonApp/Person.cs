﻿using System;

namespace FirstConsoleLessonApp
{
    /*
     * В этом классе можно создавать и статические и не статические методы.
     */ 
    public class Person
    {
        /*
         * Поля всегда начинаются с нижнего подчёркивания, после подчёркивания идёт название с маленькой буквы.
         * 
         */
        public string _name;

        /*
         * Свойства.
         * Синтаксис: [модификатор доступа] [дополнительные ключевые слова] типВозвращаемогоЗначения Имя { get; set; }
         * Имя всегда с большой буквы
         * 
         * Обращаться нужно через точку без скобок как у метода.
         * 
         * Можно сделать свойство с более подробным описанием, как ниже, там можно добавлять проверки и т.д.
         * Или же просто записать get; set; Тогда будет использоваться реализация по умолчанию.
         * Работать будет одинаково.
         * 
         * Так же можно при перемещении курсора на имя свойства нажать на появившуюся отвёртку и заменить
         * это свойство на методы(геттер и сеттер).
         * 
         * Для get и set можно установить модификатор доступа, но только либо для get, либо для set. 
         * Причём нельзя установить модификатор public.
         */
        public string Name // это свойство. В данном случае оно относится к полю _name
        {
            //get
            //{
            //    return _name;
            //}
            get;
            set;
            //set
            //{
            //    _name = value; // value - это входное значение
            //}
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void PrintName()
        {
            Console.WriteLine(_name);
        }
    }
}