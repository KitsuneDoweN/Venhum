using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimator : MonoBehaviour
{
    [SerializeField] private Animator m_aniModel;
    [SerializeField] private SpriteRenderer m_srModel;


    /*animator의 fDir의 설정 값
    0.0f은 Front
    0.5f은 Side
    1.0f은 Back*/
    public void setMoveAnimation(bool bWalk, Vector2 v2Dir)
    {
        m_aniModel.SetBool("bWalk", bWalk);

        if (v2Dir.y < 0.4f && v2Dir.y > -0.4f)
        {
            m_aniModel.SetFloat("fDir", 0.5f);

            m_srModel.flipX = true;
            if (v2Dir.x > 0)
                m_srModel.flipX = false;
        }
        else if (v2Dir.y > 0.0f)
        {
            m_aniModel.SetFloat("fDir", 1.0f);
        }
        else if (v2Dir.y < 0.0f)
        {
            m_aniModel.SetFloat("fDir", 0.0f);
        }
    }

}
