/******************************************************************************\
* �ˣ��ұ�����ӵ����Դ�� �ٳٿ�Դ �������£�                                  *
* Leap4Unity1.0  ���ڸ���Sample�Ļ���֮����ӵĹ��ܺ͹��� Ŀǰֻ�Ǽ򵥵�ʶ��  *
* ������ڰ����ĵ��￴��������ߵ�ʵ�÷���                                    *
* �����Ը�� ���Բ��������http://www.enjoythis.net/forum.php                 * 
 * �����������������ӭ�㹲����� �����ʹ��������                            *
 * �����ʹ�õ��κ���ҵ���߷���ҵ;��                                         *
* �����ڷ���Leap�����ĵ� ������һ��ѧϰ�� QQȺ�� 94418644  һ��ɣ�           *
\******************************************************************************/

using UnityEngine;
using System.Collections;
using Leap;
public static class LeapScreenManager
{

    static Leap.Controller m_controller = new Leap.Controller();
    static Leap.Frame m_Frame = null;

    public static Leap.Frame Frame
    {
        get { return m_Frame; }
    }

    public static void ScreenUpdate()
    {
        if (m_controller != null)
        {
            Frame lastFrame = m_Frame == null ? Frame.Invalid : m_Frame;
            m_Frame = m_controller.Frame();
            ScreenList sl = m_controller.LocatedScreens;

        }
    }

    public static Vector3 IntersectToScreen(Pointable p)
    {
        Vector3 IntersectPoint = new Vector3();
        ScreenList sl = m_controller.LocatedScreens;
        IntersectPoint = sl[0].Intersect(p, true).ToUnity();
        return new Vector3(IntersectPoint.x * UnityEngine.Screen.width, IntersectPoint.y * UnityEngine.Screen.height, 1);
    }
}
