using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_In_A_Row
{
	public partial class Form1 : Form
	{
		ArrayList arrayList = new ArrayList();		// 모든 값 저장
		ArrayList brokenList = new ArrayList();		// 연속이 끊어진 값 저장

		public Form1()
		{
			InitializeComponent();
		}

		/*
		 
		 * Program Logic
		 * 
		 * 텍스트를 검사해서 s-구문이 들어가면 저장 안 하고, 원본 파일만 int 배열에 저장
		 * 배열 크기만큼 반복문 돌려서 인덱스가 맞는지 파악
		 * 틀린 곳이 있다면 그 인덱스를 brokenList 에 추가
		 * result 된 값을 텍스트로 보여준다
		 
		*/ 

		// StringToInt()  --> int 배열에 저장
		// CheckBrokenBridge(result array) --> 연속된 숫자 체크, 연속된 숫자 끊어진 얘들 반환

		private void ReadFolderFile(string path)
		{
			try
			{
				if(System.IO.Directory.Exists(path))
				{
					System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(path);		// 폴더 정보 클래스 생성

					DirName.Text = directoryInfo.Name;		// 폴더 이름 표시


					foreach (var item in directoryInfo.GetFiles())
					{
						if(!item.Name.Contains("s-"))
						{
							arrayList.Add(Int32.Parse(item.Name.Substring(0, 5)));
						}
					}
				}
			}
			catch(Exception e)
			{
				Text_Result.Text = e.Message;
				Console.WriteLine(e);
			}


			foreach (var item in arrayList)
			{
				Console.WriteLine(item);
			}
			//Console.WriteLine("리스트 크기 : " + arrayList.Count);
		}

		private void CheckBrokenBridge()
		{
			int index = 0;
			int count = 0;

			try
			{
				for(index = 0; index < arrayList.Count; index++)
				{
					
					if(index+1 != arrayList.Count)
					for(count = (int)arrayList[index] + 1; count < (int)arrayList[index+1]; count++)
					{
						//Console.WriteLine("로직 진행중 : " + count);
							brokenList.Add(count);
					}
				}
			}
			catch(Exception e)
			{
				Text_Result.Text = e.Message;
				Console.WriteLine(e);
			}
		}

		private void ShowBrokenValue()
		{
			Text_Result.Text = "누락된 렌즈 : \r\n";

			if (LookOne.Checked)
			{
				try
				{
					int i = 0;
					int lastOne = brokenList.Count;

					foreach (int broken in brokenList)
					{
						if(++i == lastOne)
							Text_Result.Text += broken.ToString() + "번\r\n 총 " + brokenList.Count + "개 누락";
						else
						{
							Text_Result.Text += broken.ToString() + "번, ";
						}
					}
				}
				catch(Exception e)
				{
					Text_Result.Text = e.Message;
					Console.WriteLine(e);
				}
			}
			
			else if(LookInARow.Checked)
			{
				try
				{
					int before_index = 0;

					for(int index = 0; index < brokenList.Count; index++)
					{	
						if(index != brokenList.Count-1 && ((int)brokenList[index] + 1 == (int)brokenList[index + 1]))
						{
							continue;
						}
						else if (index != brokenList.Count-1 && before_index == index && ((int)brokenList[index] + 1 != (int)brokenList[index + 1]))
						{
							Text_Result.Text += brokenList[index] + "번\r\n";
							//Console.WriteLine(brokenList[index] + "번\r\n");
							before_index = index;
						}
						else if (index != brokenList.Count-1 &&((int)brokenList[index] + 1 != (int)brokenList[index + 1]))
						{
							Text_Result.Text += brokenList[before_index] + "번 ~ " + brokenList[index] + "번\r\n";
							//Console.WriteLine(brokenList[before_index] + "번 ~ " + brokenList[index] + "번\r\n");
							before_index = index;
						}
						else if(index == brokenList.Count - 1)
						{
							Text_Result.Text += brokenList[before_index] + "번 ~ " + brokenList[index] + "번\r\n";
							//Console.WriteLine(brokenList[before_index] + "번 ~ " + brokenList[index] + "번\r\n");
						}

							before_index++;
					}

					Text_Result.Text += "총 " + brokenList.Count + "개 누락";
				}
				catch(Exception e)
				{
					Text_Result.Text = e.Message;
				}

			}

		}

		private void GetDir_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if(fbd.ShowDialog() == DialogResult.OK)
			{
				arrayList.Clear();      // 저장된 리스트 초기화
				brokenList.Clear();		// "

				ReadFolderFile(fbd.SelectedPath);   // 폴더 읽어오기

				CheckBrokenBridge();        // 끊어진 지점 체크

				ShowBrokenValue();			// 끊어진 값들 보여주기
			}
		}

		private void LookOne_CheckedChanged(object sender, EventArgs e)
		{
			ShowBrokenValue();
		}

		private void LookInARow_CheckedChanged(object sender, EventArgs e)
		{
			//ShowBrokenValue();
		}
	}
}
