using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PatternManager : MonoBehaviour
{
    private float angle = 0f;
    private float startAngle = 90f, endAngle = 270f;

    public Text textBox;
    public float timeStart = 221;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());

        textBox.text = timeStart.ToString("F1");
    }

    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = timeStart.ToString("F1");
    }

    IEnumerator Timer()
    {
        //
        Invoke("Burst", 0f);
        Invoke("Burst2", 4.15f);
        Invoke("Burst", 8f);
        Invoke("Burst2", 11.75f);
        Invoke("Burst", 15.6f);

        //
        Invoke("Burst2", 17.7f);
        Invoke("Burst", 19.45f);
        Invoke("Burst2", 23.35f);
        Invoke("Burst", 27f);
        Invoke("BigBurst", 31f);

        //
        Invoke("BigBurst", 34.4f);
        Invoke("Burst", 38.7f);
        Invoke("Burst2", 42.6f);
        InvokeRepeating("Burst2", 46.6f, 0.25f);

        //
        InvokeRepeating("Spiral", 2f, 0.75f);

        yield return new WaitForSeconds(7.8f);//7.8
        CancelInvoke("Spiral");
        yield return new WaitForSeconds(0.1f);//7.9
        InvokeRepeating("Spiral", 0f, 0.45f);
        InvokeRepeating("Spiral2", 0.45f, 0.45f);
        yield return new WaitForSeconds(38.7f);//46.6
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2");
        yield return new WaitForSeconds(3.3f);//49.9
        CancelInvoke("Burst2");
        InvokeRepeating("Spiral", 0f, 0.45f);
        InvokeRepeating("Spiral2", 0.45f, 0.45f);
        yield return new WaitForSeconds(0.1f);//even 50
        Invoke("BigBurst", 0.2f);
        Invoke("Burst", 2.2f);
        Invoke("Burst2", 4.4f);
        Invoke("BigBurst", 8f);
        Invoke("Burst2", 10f);
        InvokeRepeating("Burst2", 10.8f, 0.1f);
        yield return new WaitForSeconds(11.6f);//61.6
        CancelInvoke("Burst2");
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2");
        InvokeRepeating("Spiral", 0.5f, 0.23f);
        yield return new WaitForSeconds(15.3f);//76.9
        CancelInvoke("Spiral");
        InvokeRepeating("Burst2", 0.4f, 0.2f);
        yield return new WaitForSeconds(3.8f);//80.7
        CancelInvoke("Burst2");
        InvokeRepeating("Spiral", 0.3f, 0.2f);
        yield return new WaitForSeconds(3.8f);//84.5
        CancelInvoke("Spiral");
        InvokeRepeating("BigBurst", 0.4f, 0.2f);
        yield return new WaitForSeconds(3.8f);//88.3
        CancelInvoke("BigBurst");
        InvokeRepeating("Spiral2", 0.5f, 0.2f);
        yield return new WaitForSeconds(3.7f);//92
        CancelInvoke("Spiral2");
        InvokeRepeating("Burst", 2.1f, 0.1f);
        yield return new WaitForSeconds(2.2f);//94.4
        CancelInvoke("Burst");
        Invoke("BigBurst", 0f);
        Invoke("BigBurst", 0.2f);
        yield return new WaitForSeconds(0.1f);//94.5
        InvokeRepeating("Spiral", 1f, 0.4f);
        InvokeRepeating("Spiral2", 1.25f, 0.4f);
        InvokeRepeating("Spiral", 1.55f, 0.4f);
        InvokeRepeating("Spiral2", 1.75f, 0.4f);
        yield return new WaitForSeconds(0.5f);//95
        Invoke("Burst2", 2.7f); Invoke("Burst2", 2.8f); Invoke("Burst2", 2.9f);
        Invoke("Burst2", 6.7f); Invoke("Burst2", 6.8f); Invoke("Burst2", 6.9f);
        Invoke("Burst2", 10.3f); Invoke("Burst2", 10.4f); Invoke("Burst2", 10.5f);
        Invoke("Burst2", 14.3f); Invoke("Burst2", 14.4f); Invoke("Burst2", 14.5f);
        yield return new WaitForSeconds(15f);//110
        Invoke("BigBurst", 0.3f);
        Invoke("Burst2", 3.1f); Invoke("Burst2", 3.2f); Invoke("Burst2", 3.3f);
        Invoke("Burst2", 7f); Invoke("Burst2", 7.1f); Invoke("Burst2", 7.2f);
        Invoke("Burst2", 10.8f); Invoke("Burst2", 10.9f); Invoke("Burst2", 11f);
        yield return new WaitForSeconds(15.3f);//125.3
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2");
        InvokeRepeating("Spiral", 0f, 0.3f);
        yield return new WaitForSeconds(0.7f);//126
        Invoke("Burst", 0.2f); Invoke("Burst", 0.3f); Invoke("Burst", 0.4f);
        Invoke("Burst2", 1.2f); Invoke("Burst2", 1.3f); Invoke("Burst2", 1.4f);
        Invoke("Burst", 3.2f); Invoke("Burst", 3.3f); Invoke("Burst", 3.4f);
        Invoke("Burst2", 4.2f); Invoke("Burst2", 4.3f); Invoke("Burst2", 4.4f);
        Invoke("Burst", 6.4f); Invoke("Burst", 6.5f); Invoke("Burst", 6.6f);
        Invoke("Burst2", 7.5f); Invoke("Burst2", 7.6f); Invoke("Burst2", 7.7f);
        Invoke("Burst", 11f); Invoke("Burst", 11.1f); Invoke("Burst", 11.2f);
        Invoke("Burst2", 12.8f); Invoke("Burst2", 12.9f); Invoke("Burst2", 13f);
        InvokeRepeating("Spiral2", 7f, 0.25f);
        yield return new WaitForSeconds(14.6f);//140.6
        CancelInvoke("Burst");
        CancelInvoke("Burst2");
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2");
        Invoke("BigBurst", 0f);
        InvokeRepeating("Spiral", 1f, 0.4f);
        InvokeRepeating("Spiral2", 1.33f, 0.4f);
        InvokeRepeating("Spiral", 1.55f, 0.4f);
        InvokeRepeating("Spiral2", 1.77f, 0.4f);
        yield return new WaitForSeconds(0.4f);//141
        Invoke("Burst", 3.3f); Invoke("Burst", 3.4f); Invoke("Burst", 3.5f);
        Invoke("Burst2", 6.8f); Invoke("Burst2", 6.9f); Invoke("Burst2", 7f);
        Invoke("Burst", 10.7f); Invoke("Burst", 10.8f); Invoke("Burst", 10.9f);
        Invoke("Burst2", 14.6f); Invoke("Burst2", 14.7f); Invoke("Burst2", 14.8f);
        Invoke("BigBurst", 14.9f);
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2"); 
        InvokeRepeating("Spiral", 1f, 0.4f);
        InvokeRepeating("Spiral2", 1.33f, 0.4f);
        yield return new WaitForSeconds(14f);//155
        Invoke("Burst", 4.3f); Invoke("Burst", 4.4f); Invoke("Burst", 4.5f);
        Invoke("Burst2", 8.3f); Invoke("Burst2", 8.4f); Invoke("Burst2", 8.5f);
        Invoke("Burst", 12.3f); Invoke("Burst", 12.4f); Invoke("Burst", 12.5f);
        Invoke("BigBurst", 1f);
        InvokeRepeating("Spiral", 1f, 0.4f);
        InvokeRepeating("Spiral2", 1.33f, 0.4f);
        yield return new WaitForSeconds(17f);//172
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2");
        InvokeRepeating("Spiral", 0f, 0.2f);
        InvokeRepeating("Spiral", 1f, 0.6f);
        InvokeRepeating("Spiral2", 1.33f, 0.6f);
        InvokeRepeating("Spiral", 1.55f, 0.6f);
        InvokeRepeating("Spiral2", 1.77f, 0.6f);
        Invoke("BigBurst", 10f);
        Invoke("BigBurst", 18f);
        yield return new WaitForSeconds(1.3f);//173.3
        CancelInvoke("Spiral");
        InvokeRepeating("Spiral", 0f, 0.23f);
        InvokeRepeating("Spiral2", 0.45f, 0.23f);
        yield return new WaitForSeconds(1.3f);//174.9
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2");
        InvokeRepeating("Spiral", 1f, 0.23f);
        InvokeRepeating("Spiral2", 1.45f, 0.23f);
        InvokeRepeating("Spiral", 1f, 0.33f);
        InvokeRepeating("Spiral2", 1.45f, 0.33f);
        yield return new WaitForSeconds(27.1f);//202
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2");
        InvokeRepeating("Spiral", 0f, 0.45f);
        InvokeRepeating("Spiral2", 0.45f, 0.45f);
        yield return new WaitForSeconds(16f);//218
        CancelInvoke("Spiral");
        CancelInvoke("Spiral2");
        yield return new WaitForSeconds(3f);//221
        SceneManager.LoadScene(4);
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

        for (int i = 0; i < 7 + 1; i++)
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
