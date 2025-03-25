namespace 배열
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int value; // 정수 저장소 value로 하나 만들기
            //  value = 10; // 저장소에 10 저장하기
            //
            //  int[] values; // 정수 여러개 담을 수 있는 저장소 만들기
            //  values = new int[10]; //10개짜리 저장소 만들기

            //  int[] scores = new int[5];
            //
            //  scores[0] = 10; // 0번째 요소 저장
            //  scores[1] = 20; // 1번째 요소 저장
            //  scores[2] = 30; // 2번째 요소 저장
            //  scores[3] = 40; // 3번째 요소 저장
            //  scores[4] = 50; // 4번째 요소 저장
            //
            //  Console.WriteLine(scores[0]);    // 0번째 요소 저장
            //  Console.WriteLine(scores[1]);    // 1번째 요소 저장
            //  Console.WriteLine(scores[2]);    // 2번째 요소 저장
            //  Console.WriteLine(scores[3]);    // 3번째 요소 저장
            //  Console.WriteLine(scores[4]);    // 4번째 요소 저장
            //  
            //  Console.WriteLine("배열이 있는 갯수는 : {0}",scores.Length); // 배열.Length(길이) : 총 배열 갯수


            //  string[] shortCuts = new string[5];

            //  shortCuts[0] = "포션";
            //  shortCuts[1] = "파폭";
            //  shortCuts[2] = "부적";
            //  shortCuts[3] = "폭탄";
            //  shortCuts[4] = "연막";

            //  for (int i = 0; i < shortCuts.Length; i++) // 4회 반복
            //  {
            //      Console.WriteLine("{0}번째 아이템은 {1} 입니다.", i + 1, shortCuts[i]);
            //  }

            //  foreach (string item in shortCuts)
            //  {
            //      Console.WriteLine("배열에 있는 아이템 : {0}", item);
            //  }

            // string[] students = new string[75];
            // string[,] shortCuts = new string[3, 4];
            //
            // shortCuts[0, 0] = "대검";
            // shortCuts[0, 1] = "태도";
            // shortCuts[0, 2] = "한손검";
            // shortCuts[0, 3] = "쌍검";
            //
            // shortCuts[1, 0] = "랜스";
            // shortCuts[1, 1] = "건랜스";
            // shortCuts[1, 2] = "해머";
            // shortCuts[1, 3] = "수렵피리";
            //
            // shortCuts[2, 0] = "조충곤";
            // shortCuts[2, 1] = "헤비보우건";
            // shortCuts[2, 2] = "라이트보우건";
            // shortCuts[2, 3] = "활";
            //
            // for (int i = 0; i < shortCuts.GetLength(0); i++)
            // {
            //     for (int j = 0; j < shortCuts.GetLength(1); j++)
            //     {
            //         Console.WriteLine("{0} 번째줄 {1} 번째 아이템 : {2}", i, j, shortCuts[i, j]);
            //     }
            //
            //     
            // }
            //
            // Console.WriteLine("총 아이템 갯수는 {0}",shortCuts.Length);

            //     string text = "abcde";
            //
            //     char[] array = text.ToCharArray();
            //
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         Console.WriteLine(array[i]);
            //     }
            //     array[2] = 'x'; // 2번째 문자를 'x'로 바꿔줘
            //
            //     for (int i = 0; i < array.Length; i++)
            //     {
            //         Console.WriteLine(array[i]); // 문자 하나씩 출력
            //     }
            //
            //     text = new string(array); // new : 저장소를 만들고 찾아 들어간다
            //     Console.WriteLine(text); //문자열 전체를 출력


            //   for (int i = 128; i >= 20; i/=2)
            //   {
            //       Console.Write(i);
            //   }

          }
    }
}





﻿namespace _11._Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*******************************************************************
             * 배열 (Array)
             * 
             * 동일한 자료형의 요소들로 구성된 데이터 집합
             * 인덱스를 통하여 배열요소(Element)에 접근할 수 있음
             * 배열의 처음 요소의 인덱스는 0부터 시작함
             *******************************************************************/

            // <배열 기본>
            // 배열을 만들기 위해 자료형과 크기를 정하여 생성
            // 배열의 요소에 접근하기 위해 [인덱스] 를 사용
            // 배열의 Length 를 통해 크기를 확인
            // 자료형[] 배열이름 = new 자료형[크기];
            int[] scores = new int[5];      // 크기 5의 배열 선언

            scores[0] = 10;                 // 0번째 요소 저장
            scores[1] = 20;                 // 1번째 요소 저장
            scores[2] = 30;                 // 2번째 요소 저장
            scores[3] = 40;                 // 3번째 요소 저장
            scores[4] = 50;                 // 4번째 요소 저장

            Console.WriteLine($"배열의 0번째 요소 : {scores[0]}");     // 0번째 요소 불러오기
            Console.WriteLine($"배열의 1번째 요소 : {scores[1]}");     // 1번째 요소 불러오기
            Console.WriteLine($"배열의 2번째 요소 : {scores[2]}");     // 2번째 요소 불러오기
            Console.WriteLine($"배열의 3번째 요소 : {scores[3]}");     // 3번째 요소 불러오기
            Console.WriteLine($"배열의 4번째 요소 : {scores[4]}");     // 4번째 요소 불러오기


            // <배열 선언 및 초기화>
            int[] array1;                           // 배열 변수 선언
            array1 = new int[3];                    // 데이터를 3개 가지는 배열 생성
            int[] array2 = new int[3] { 1, 2, 3 };  // 크기가 3인 배열을 선언하고 배열 요소들을 초기화
            int[] array3 = new int[] { 1, 2, 3 };   // 배열의 요소들을 초기화 하는 경우 배열의 크기를 생략 가능
            int[] array4 = { 1, 2, 3 };             // 배열의 요소들을 초기화 하는 경우 배열 생성을 생략 가능


            // <배열의 구현 원리>
            // C#의 배열은 Array 클래스를 통해 구현됨
            // 따라서 Array 클래스의 모든 특징을 가짐
            // Array 클래스의 정적 함수를 활용하여 다양한 기능 사용 가능
            int[] array = { 1, 3, 5, 4, 2 };

            int length = array.Length;   // 배열의 크기
            int max = array.Max();       // 배열의 최대값
            int min = array.Min();       // 배열의 최소값

            Array.Sort(array);                      // 배열 정렬
            Array.Reverse(array);                   // 배열 반전
            int index = Array.IndexOf(array, 3);    // 배열 탐색

            int[] shallow = array;                  // 배열의 얕은 복사 : 동일한 인스턴스를 참조
            int[] deep = new int[array.Length];     // 배열의 깊은 복사 : 새로운 인스턴스를 생성하고 복사
            Array.Copy(array, deep, array.Length);

            array[0] = 0;
            Console.WriteLine(array[0]);            // output : 0
            Console.WriteLine(shallow[0]);          // output : 0
            Console.WriteLine(deep[0]);             // output : 5


            // <인덱스>
            // 배열은 요소들을 메모리에 연속적으로 배치하는 원리로 구현
            // 이를 이용하여 배열의 특정요소의 메모리주소를 계산할 수 있음
            // i번째 배열요소 메모리주소 == 배열 시작 메모리주소 + (i * 자료형의 크기)
            // 이를 인덱스라고 표현함


            // <다차원 배열>
            // 배열의 []괄호 안에 차원수만큼 ','를 추가
            // 배열의 크기가 차원마다 동일함
            int[,] matrix = new int[3, 4];          // 2차원 배열 선언
            // [0,0] [0,1] [0,2] [0,3]
            // [1,0] [1,1] [1,2] [1,3]
            // [2,0] [2,1] [2,2] [2,3]
            matrix[2, 1] = 10;                      // 2차원 배열의 y:2 x:1 배열요소 저장
            Console.WriteLine(matrix[2, 1]);        // 2차원 배열의 y:2 x:1 배열요소 불러오기
            Console.WriteLine(matrix.GetLength(0)); // 2차원 배열의 y 크기
            Console.WriteLine(matrix.GetLength(1)); // 2차원 배열의 x 크기

            int[,,] cube = { { {1, 2}, {3, 4} }, { {5, 6}, {7, 8} } };      // 3차원 배열 선언 및 초기화


            // <가변 배열>
            // 배열의 []괄호를 배열 갯수만큼 추가
            // 배열의 크기를 각각 설정 가능
            int[][] jagged = new int[3][];          // 배열의 갯수 설정
            jagged[0] = new int[5];
            jagged[1] = new int[2];
            jagged[2] = new int[3];
            // [0][0] [0][1] [0][2] [0][3] [0][4]
            // [1][0] [1][1]
            // [2][0] [2][1] [2][2]


            // <배열과 반복>
            // 배열의 인덱스를 반복하여 증가시키며 사용하는 경우 배열의 모든 요소를 반복 수행하는데 용이함
            int[] ints = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(ints[i]);
            }

            int[,] tile = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int y = 0; y < tile.GetLength(0); y++)
            {
                for (int x = 0; x < tile.GetLength(1); x++)
                {
                    Console.Write(tile[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
