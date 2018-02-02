using Br.Weapon;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{

    public float speed;

    private Transform m_MyTransform;

    private Rigidbody2D rb2d;

    public Vector2 localScale;
    [SerializeField]
    bool isInputMoveH;
    [SerializeField]
    bool isInputMoveV;


    private Vector3 m_MousePosition;


    [SerializeField]
    private Transform m_CharacterWeapon;
    private Vector3 m_CharacterWeaponScale;
    [SerializeField]
    private Transform m_CharacterBody;
    private Vector3 m_CharacterBodyScale;

    private IGun currentGun;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        m_MyTransform = GetComponent<Transform>();
        localScale = m_MyTransform.localScale;


        m_CharacterBodyScale = m_CharacterBody.localScale;
        m_CharacterWeaponScale = m_CharacterWeapon.localScale;


        currentGun = m_CharacterWeapon.GetChild(0).GetComponent<IGun>();
    }

    void Update()
    {

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        isInputMoveH = Horizontal < 0 || Horizontal > 0 ? true : false;
        isInputMoveV = Vertical < 0 || Vertical > 0 ? true : false; 

        if (!isInputMoveH && !isInputMoveV)
        {
            rb2d.MovePosition(rb2d.position);
        }

        rb2d.MovePosition(new Vector2(rb2d.position.x + (Horizontal * speed), rb2d.position.y + (Vertical * speed)));

        /*
         * 
         * Rotation Weapon ( mouse position )
         * 
         */

        m_MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 dir = m_MousePosition - m_CharacterWeapon.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        m_CharacterWeapon.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


        if(m_MousePosition.x <= m_MyTransform.transform.position.x)
        {
            m_CharacterWeapon.localScale = new Vector3(m_CharacterWeapon.localScale.x,  -m_CharacterWeaponScale.y);
            m_CharacterBody.localScale = new Vector3(-m_CharacterBodyScale.x, m_CharacterBody.localScale.y);
        }
        else
        {
            m_CharacterWeapon.localScale = new Vector3(m_CharacterWeapon.localScale.x, m_CharacterWeaponScale.y);
            m_CharacterBody.localScale = new Vector3(m_CharacterBodyScale.x, m_CharacterBody.localScale.y);
        }


        if(Input.GetMouseButton(0))
        {
            currentGun.Shoot();
        }
    }
}

