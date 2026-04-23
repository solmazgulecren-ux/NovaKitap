// Kutup Yıldızı Kaydetme İşlemi (AJAX ile)
function toggleStar(button, kitapId) {
    const emptyStar = '✧';
    const filledStar = '✦';

    // Geçerli yıldız durumunu kontrol et
    let isSaved = button.innerText.trim() === filledStar;

    // Görseli anında değiştir (Kullanıcıya hızlı tepki vermek için - Optimistic UI)
    if (isSaved) {
        button.innerText = emptyStar;
        button.style.color = 'var(--star-beige)';
        button.style.textShadow = 'none';
    } else {
        button.innerText = filledStar;
        button.style.color = '#ffffff'; // Dolduğunda daha parlak beyaz
        button.style.textShadow = '0 0 10px var(--star-beige)';
    }

    // Arka planda Controller'a istek at (Yolu /Home/KaydetToggle olarak güncelledik)
    fetch(`/Home/KaydetToggle?kitapId=${kitapId}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => {
            if (!response.ok) {
                // Eğer giriş yapılmamışsa veya hata varsa görseli eski haline çevir
                if (isSaved) {
                    button.innerText = filledStar;
                    button.style.color = '#ffffff';
                    button.style.textShadow = '0 0 10px var(--star-beige)';
                } else {
                    button.innerText = emptyStar;
                    button.style.color = 'var(--star-beige)';
                    button.style.textShadow = 'none';
                }

                // 401 (Yetkisiz) hatası dönerse giriş sayfasına at
                if (response.status === 401) {
                    alert("Yıldız sistemine kayıt yapmak için lütfen önce giriş yapın!");
                    window.location.href = "/Hesap/GirisYap";
                }
            }
        })
        .catch(error => {
            console.error("Hata oluştu:", error);
        });
}