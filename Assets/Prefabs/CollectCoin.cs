using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public float speed = 10f; 

  void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); //tạo chuyển động theo phương thẳng đứng hướng xuống với tốc độ trên theo thời gian
    }
    void OnTriggerEnter2D(Collider2D other) //other chính là thông tin của bất kỳ collider nào va chạm với collider này
    {
		// thiết lập điều kiện kiểm tra thông tin của OTHER
    if (other.gameObject.CompareTag("Player")) 
      // nếu, phương thức so sánh gameobject tag của other với nhãn "Player" là đúng
    { // thì
      Destroy(gameObject);
      ScoreManager.AddScore(1);
      AudioSource audioSource = GetComponent<AudioSource>();
      audioSource.Play();
    }
    }
};