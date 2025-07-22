import React, {useState} from 'react';
import './index.css'

function App() {
  // useState Renderlar Arasında Verimizi Tutmamızı Sağlayan Bir React Hook'udur.
  // Component Fonksiyonumuz Her Renderda Temizlenip Tekrar Compute Edilir.
  // Değişkenlerimiz ve Verilerimiz Tekrar Compute Edilince İnitial Değerine Geri Döner.
  // Bu Sorunu Çözmek İçin Verilerimizi useState İle Tutarız.
  // useState Bir Fonksiyondur, Parametre Olarak Tutmak İstediğimiz Verinin Başlangıç Değerini Alır. Veya Başlangıç Değerini Oluşturan Bir Fonksiyon Olabilir.
  const [count, setCount] = useState(0);

  function arttir() {
    // setCount(count + 1);
    // setCount(count + 1);
    setCount(count => count + 1);
    setCount(count => count + 1);
    // => Veri Tutma İşlemi Asenkron Çalışır. Bu Yüzden Yukarıdaki Gibi İki Kez Çağırdığımızda, İlk Çağrıda Count 0'dan 1'e Çıkar, İkinci Çağrıda İse 1'den 2'ye Çıkar.
  };

  function azalt() {
    setCount(count - 1);
  };

  function kisiyazdir(parametre) {
    return parametre.isim + " " + parametre.soyisim + " " + parametre.departman; // Burada Veri Tanımlıysa Alır Tanımlı Değilse Undefine Döner.
  };

  const isim = "Murtaza Şuayipoğlu";
  const etiket = <h3>Merhaba {isim}</h3>;

  const kisi = {
    isim: "Murtaza",
    soyisim: "Şuayipoğlu"
  };

  const personel = {
    isim: "Armağan",
    soyisim: "Tambova",
    departman: "Yazılım Geliştirme",
  };
  
  return (
    <>
      <div>
        <ul>
        <li>React</li>
        <li>JavaScript</li>
        <li>CSS</li>
        <li>HTML</li>
        <li>Node.js</li>
        <li>Express</li>
        <li>MongoDB</li>
        <li>REST API</li>
        <li>GraphQL</li>
        <li>TypeScript</li>
      </ul>
      </div>

      <section className='ImageBackgorund'>
      
      </section>

      <div className='counter'>
        <button onClick={azalt}>-</button>
        <span>{count}</span>
        <button onClick={arttir}>+</button>
      </div>

      <div className='counter'>
        {etiket}
      </div>

      <div className='counter'>
        <h3>{kisiyazdir(kisi)}</h3>
      </div>

      <div className='counter'>
        <h3>{kisiyazdir(personel)}</h3>
      </div>

      <div className='counter'>
        <h3>{kisiyazdir(personel).toUpperCase()}</h3>
      </div>

      <div className='counter'>
        <h3 style={{color:"pink"}}>{kisiyazdir(personel).toUpperCase()}</h3>
      </div>
    </>
  );
}

export default App;
