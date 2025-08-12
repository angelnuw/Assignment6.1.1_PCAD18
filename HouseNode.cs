using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment6._1._1
{
    public class HouseNode
    {
        public int HouseNumber;
        public string Address;
        public string HouseType;
        public HouseNode Next;
        public HouseNode(int number, string address, string type)
        {
            this.HouseNumber = number;
            this.Address = address;
            this.HouseType = type;
            this.Next = null;
        }
    }

    public class HouseLinkedList
    {
        private HouseNode head;
        private HouseNode tail;
        private int size;
        public int Size
        {
            get { return size; }
        }
        public HouseLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddFirst(int number, string address, string type)
        {
            if (IsHouseNumberExists(number))
            {
                Console.WriteLine("House number already exists.");
                return;
            }

            var newNode = new HouseNode(number, address, type);

            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            size++;
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }

            var cur = head;
            Console.WriteLine("Number | Address | Type");
            while (cur != null)
            {
                Console.WriteLine($"#{cur.HouseNumber} | {cur.Address} | {cur.HouseType}");
                cur = cur.Next;
            }
        }
        private bool IsHouseNumberExists(int number)
        {
            var current = head;
            while (current != null)
            {
                if (current.HouseNumber == number)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void AddLast(int number, string address, string type)
        {
            if (IsHouseNumberExists(number))
            {
                Console.WriteLine("House number already exists.");
                return;
            }

            var newNode = new HouseNode(number, address, type);

            if (IsEmpty())
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            size++;
        }
        public HouseNode SearchByNumber(int number)
        {
            var cur = head;
            while (cur != null)
            {
                if (cur.HouseNumber == number)
                {
                    return cur;
                }
                cur = cur.Next;
            }
            return null;
        }

    }
}
