using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatternManager : MonoBehaviour
{
    private float angle = 0f;
    private float startAngle = 90f, endAngle = 270f;

    public Text textBox;
    public float timeStart = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());

        textBox.text = timeStart.ToString("F1");
    }

    void Update()
    {
        timeStart += Time.deltaTime;
        textBox.text = timeStart.ToString("F1");
    }

    IEnumerator Timer ()
    {
        //
        Invoke("Burst", 0f);
        Invoke("Burst2", 4.15f);
        Invoke("Burst", 8f);
        Invoke("Burst2", 11.75f);
        Invoke("Burst", 15.6f);

        //
        Invoke("Burst", 19.45f);
        Invoke("Burst2", 23.35f);
        Invoke("Burst", 27f);
        Invoke("BigBurst", 31f);

        //
        InvokeRepeating("Spiral", 2f, 0.75f);

        yield return new WaitForSeconds(7.8f);
        CancelInvoke("Spiral");
        yield return new WaitForSeconds(0.1f);
        InvokeRepeating("Spiral", 0f, 0.45f);
        InvokeRepeating("Spiral2", 0.45f, 0.45f);
        InvokeRepeating("Burst", 0f, 10f);
        InvokeRepeating("BigBurst", 0f, 13.5f);
    }

    private void Burst()
    {
        float angeleStep = (endAngle - startAngle) / 10;
        float angle = startAngle;

        for (int i = 0; i < 10 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angeleStep;
        }
    }

    private void BigBurst()
    {
        float angeleStep = (endAngle - startAngle) / 7;
        float angle = startAngle;

        for (int i = 0; i < 10 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bull = BulletPool.bulletPoolInstanse.GetBigBullet();
            bull.transform.position = transform.position;
            bull.transform.rotation = transform.rotation;
            bull.SetActive(true);
            bull.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angeleStep;
        }
    }

    private void Burst2()
    {
        float angeleStep = (endAngle - startAngle) / 6;
        float angle = startAngle;

        for (int i = 0; i < 6 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angeleStep;
        }
    }

    private void Spiral()
    {
        for (int i = 0; i <= 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin(((angle + 180f * i) * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos(((angle + 180f * i) * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

        }

        angle += 10f;

        if (angle >= 360f)
        {
            angle = 0f;
        }
    }

    private void Spiral2()
    {
        for (int i = 0; i <= 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin(((angle + 270f * i) * Mathf.PI) / 270f);
            float bulDirY = transform.position.y + Mathf.Cos(((angle + 270f * i) * Mathf.PI) / 270f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

        }

        angle += 10f;

        if (angle >= 360f)
        {
            angle = 0f;
        }
    }

    private void SmallBurst()
    {
        float angeleStep = (endAngle - startAngle) / 6;
        float angle = startAngle;

        for (int i = 0; i < 6 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angeleStep;
        }
    }

    private void SmallBurst2()
    {
        float angeleStep = (endAngle - startAngle) / 6;
        float angle = startAngle;

        for (int i = 0; i < 6 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<Bullet>().SetMoveDirection(bulDir);

            angle += angeleStep;
        }
    }
}
