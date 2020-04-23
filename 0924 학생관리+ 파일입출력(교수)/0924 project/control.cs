﻿using System;
using System.IO;

namespace _0924_project
{
    class control
    {
        //저장소========================
        wbarray array = null;
        //==============================

        public void filesave()
        {
            //wbfile.filesave(array.Memlist,array.Size);
            wbfile.filesersave(array.Memlist, array.Size);
        }
        public void fileload()
        {
            try {
                //member[] arr=wbfile.fileload();
                int max;
                member[] arr = wbfile.fileserload(out max);
                array = new wbarray(max);

                for (int i = 0; i < arr.Length; i++)
                {
                    member mem = arr[i];
                    array.insert(mem);
                }
            }
            catch(FileNotFoundException)
            {
                //파일이 없으니깐 배열객체를 생성하겠다.
                int size = wblib.inputnumber("배열의 크기");
                array = new wbarray(size);
            }
     
        }
        public void printall()
        {
            if (array == null)
                return;
            Console.WriteLine("저장개수 : {0}개", array.Size);
            for(int i=0;i<array.Size;i++)
            {
               member mem= (member)array.getdata(i);
                Console.WriteLine(mem);
            }
        }
        private int nametoidx(string name)
        {
            for (int i = 0; i < array.Size; i++)
            {
                member mem = (member)array[i];
                //if (mem.Name.Equals(name) == true)
                if (mem==name)
                   return i;
            }
            throw new Exception("없음");
        }
        public void insert()
        {
            try {
                string name = wblib.inputstring("이름");
                string phone = wblib.inputstring("전화번호");
                int grad = wblib.inputnumber("학년");
                enumdept dept = (enumdept)wblib.inputnumber("학과 [1]컴 [2]IT [3]게임 [4]기타");

                array.insert(new member(name, phone, dept, grad));
                Console.WriteLine("저장 완료");
            }
            catch(Exception ex)
            {
                Console.WriteLine("입력 오류");
                Console.WriteLine(">> " + ex.Message);
            }
           

        }

        public void select()
        {
            try
            {
                string name = wblib.inputstring("검색 이름");

                member mem = (member)array[nametoidx(name)];
                Console.WriteLine(mem);

            }
            catch (Exception ex)
            {
                Console.WriteLine("검색 오류");
                Console.WriteLine(">> " + ex.Message);
            }


        }

        public void update()
        {
            try
            {

                string name = wblib.inputstring("수정 이름");
                member mem = (member)array[nametoidx(name)];

                mem.Phone = wblib.inputstring("전화번호");
                mem.Grad = wblib.inputnumber("학년");
                mem.Dept = (enumdept)wblib.inputnumber("학과 [1]컴 [2]IT [3]게임 [4]기타");
                Console.WriteLine("수정 완료");
            }
            catch (Exception ex)
            {
                Console.WriteLine("수정 오류");
                Console.WriteLine(">> " + ex.Message);
            }
        }

        public void delete()
        {
            try
            {
                string name = wblib.inputstring("검색 이름");

                int idx = nametoidx(name);
                array.erase(idx);
                Console.WriteLine("삭제 완료");
            }
            catch (Exception ex)
            {
                Console.WriteLine("삭제 오류");
                Console.WriteLine(">> " + ex.Message);
            }

        }


    }
}
