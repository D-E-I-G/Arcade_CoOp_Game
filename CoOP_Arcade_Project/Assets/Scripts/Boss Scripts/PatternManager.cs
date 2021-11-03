using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternManager : MonoBehaviour
{
    private float angle = 0f;

    private int bulletsAmount1 = 10;
    private int bulletsAmount2 = 6;

    private float startAngle = 90f, endAngle = 270f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spiral", 2f, 0.4f);
        InvokeRepeating("Burst", 10f, 6f);
        InvokeRepeating("Spiral", 25f, 0.7f);
        InvokeRepeating("SmallBurst", 60f, 3f);
    }

    private void Burst()
    {
        float angeleStep = (endAngle - startAngle) / bulletsAmount1;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount1 + 1; i++)
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

    private void SmallBurst()
    {
        float angeleStep = (endAngle - startAngle) / bulletsAmount2;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount2 + 1; i++)
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
