using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentoVox.Model;

namespace VentoVoxKiosk.Controller.Ext.AppThread
{
    public class IDVerifyManager
    {
        List<UserAccount> RegisteredUserList = new List<UserAccount>();


        private void InitData(List<UserAccount> data)
        {
            RegisteredUserList.Clear();
            RegisteredUserList = data;
        }

        public bool QRCheck()
        {
            bool bExist = false;

            try
            {
                var capture = new VideoCapture(0);

                Mat frame = new Mat();
                QRCodeDetector qrDetector = new QRCodeDetector();
                while (true)
                {
                    capture.Read(frame);

                    if (frame.Empty())
                    {
                        Console.WriteLine("프레임을 캡처할 수 없습니다.");
                        continue;
                    }

                    // QR 코드 디텍션을 시도합니다.
                    List<Point2f> points = new List<Point2f>();
                    bool found = qrDetector.Detect(frame, out Point2f[] detectedPoints);

                    if (found && detectedPoints.Length > 0)
                    {
                        // 점들을 리스트에 추가합니다.
                        points.AddRange(detectedPoints);
                        
                        // QR 코드 디코딩을 시도합니다.
                        string decodedText = qrDetector.Decode(frame, points);

                        if (!string.IsNullOrEmpty(decodedText))
                        {
                            // QR 코드가 성공적으로 디코딩된 경우
                            Console.WriteLine("디코딩된 텍스트: " + decodedText);

                            Cv2.WaitKey(0); // 키 입력을 기다립니다.
                            break; // 디코딩이 완료되면 루프를 종료합니다.
                        }
                    }

                    // 캡처된 프레임을 화면에 표시하여 실시간으로 확인할 수 있습니다.
                    Cv2.ImShow("Webcam Feed", frame);

                    // 'q' 키를 누르면 루프를 종료합니다.
                    if (Cv2.WaitKey(1) == 'q')
                    {
                        break;
                    }
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return bExist;
        }

        public bool IDCheck(string ID, string PW)
        {
            bool bExist = false;

            return bExist;
        }
    }
}
