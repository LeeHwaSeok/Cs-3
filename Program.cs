using System;

namespace Cs_3
{
    class Program
    {
        class Dog  // 1번 클래스 사용 
        {
            protected int eyes, nose, mouse, ears;             //클래스에서 사용할 변수 선언
            public void bark()                                  //1. 클래스 매개변수 호출해보기
            {
                Console.WriteLine("멍멍");
            }
            public Dog()                                        //2. 클래스 변수 디폴트 Dog()
            {
                eyes = 0;
                nose = 0;
                mouse = 0;
                ears = 0;
            }
            public Dog(int eyes, int nose, int mouse, int ears) //2. 클래스 변수 할당 Dog(1,2,3,4) 형식
            {
                this.eyes = eyes;
                this.nose = nose;
                this.mouse = mouse;
                this.ears = ears;
            }
            public void show()
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", eyes, nose, mouse, ears);  //str이 아니라 변수의 경우 각각 자리를 포매팅 해줘야함.
            }
            public int getEyes()                //public을 사용해야 main에서 접근이 가능함. 
            {
                return this.eyes;               //python과 동일 클래스 eyes에 접근
            }
            public int getnose()
            {
                return this.nose;
            }
            public int getmouse()
            {
                return this.mouse;
            }
            public int getears()
            {
                return this.ears;
            }

            public void seteyes(int eyes)    // 메소드를 불러와 클래스 변수를 직접 수정하는 방식
            {
                this.eyes = eyes;
            }
            public void setnose(int nose)
            {
                this.nose = nose;
            }
            public void setmouse(int mouse)
            {
                this.mouse = mouse;
            }
            public void setears(int ears)
            {
                this.ears = ears;
            }

        }
        class buldok : Dog{  //2번 상속
            private string kind;        
            public buldok(){            // dog() private -> public or protected / priavet 상태에서는 상속이 불가 
                                        // public = 어디서든 접근이 가능.
                                        // protected = 상속관계일 때 접근이 가능
                                        // private = 해당 클래스에서만 접근이 가능
                base.eyes = 0;
                base.nose = 0;
                base.mouse = 0;
                base.ears = 0;
                this.kind = "불독";
            }
            public void buldogshow(){
                Console.WriteLine("{0}, {1}, {2}, {3} {4}", eyes, nose, mouse, ears,kind);  //str이 아니라 변수의 경우 각각 자리를 포매팅 해줘야함.
            }
            public void buldogbark(){
                Console.WriteLine("으르롱");
            }
            public string getkind(){
                return this.kind;
            }
            public void setkind(string kind){
                this.kind = kind;
            }

        }
        static void Main(string[] args) //메인
        {
            //1번 클래스 이용해보기
            Dog dog = new Dog();        //인스턴스화를 통한 메모리할당, 메모리할당은 2가지 방법 [static / instance( = new 함수)]
            dog.bark();                 //함수 호출
            dog.show();                 //클래스 변수 출력

            Dog dog2 = new Dog(1, 2, 3, 4); //변수 할당
            dog2.show();
            Console.WriteLine(dog.getEyes());
            Console.WriteLine(dog2.getEyes());
            Console.WriteLine(dog.getears());   //0
            dog.setears(5);                     // ears변수 직접수정 = 5
            Console.WriteLine(dog.getears());   //5

            //2번 상속
            buldok bul = new buldok();
            bul.buldogshow();
            bul.bark();
            bul.buldogbark();
            bul.setkind("주민우");
            bul.buldogshow();

        }
    }
}
