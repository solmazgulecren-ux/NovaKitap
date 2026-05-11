// --- 1. KUTUP YILDIZI KAYDETME İŞLEMİ ---
function toggleStar(button, kitapId) {
    const emptyStar = '✧';
    const filledStar = '✦';

    let isSaved = button.innerText.trim() === filledStar;

    // Görseli anında değiştir
    if (isSaved) {
        button.innerText = emptyStar;
        button.style.color = 'var(--star-beige)';
        button.style.textShadow = 'none';
    } else {
        button.innerText = filledStar;
        button.style.color = 'var(--header-bg)';
        button.style.textShadow = '0 0 10px var(--star-beige)';
    }

    // Backend'e istek at
    fetch(`/Home/KaydetToggle?kitapId=${kitapId}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => {
            if (!response.ok) {
                if (response.status === 401) {
                    alert("Yıldız sistemine kayıt yapmak için lütfen önce giriş yapın!");
                    window.location.href = "/Hesap/GirisYap";
                }
            }
        })
        .catch(error => console.error("Hata oluştu:", error));
}

// --- 2. NOVA ASİSTAN (YAPAY ZEKA CHATBOT) İŞLEMLERİ ---

// ENTER tuşu ile mesaj gönderme
function handleChatKeyPress(event) {
    if (event.key === "Enter") {
        sendMessage();
    }
}

function sendMessage() {
    var input = document.getElementById("chat-input");
    var message = input.value.trim();
    if (message === "") return;

    var chatBody = document.getElementById("chat-body");

    // Kullanıcının mesajını ekrana yazdır
    var userDiv = document.createElement("div");
    userDiv.className = "chat-message-user";
    userDiv.innerText = message;
    chatBody.appendChild(userDiv);

    input.value = "";
    chatBody.scrollTop = chatBody.scrollHeight; // En alta kaydır

    // "Yazıyor..." Animasyonu/Görseli Ekle
    var typingDiv = document.createElement("div");
    typingDiv.className = "chat-message-bot shadow-sm";
    typingDiv.id = "typing-indicator";
    typingDiv.innerHTML = "<i>Nova Asistan düşünüyor... ✦</i>";
    chatBody.appendChild(typingDiv);
    chatBody.scrollTop = chatBody.scrollHeight;

    // C# tarafına mesajı gönder ve cevabı bekle
    fetch('/Home/AsistanCevap', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ Mesaj: message })
    })
        .then(response => response.json())
        .then(data => {
            // Cevap gelince "Yazıyor..." görselini sil
            var indicator = document.getElementById("typing-indicator");
            if (indicator) indicator.remove();

            // Yapay Zekanın gerçek cevabını ekrana bas
            var botDiv = document.createElement("div");
            botDiv.className = "chat-message-bot shadow-sm";
            botDiv.innerHTML = data.cevap.replace(/\n/g, '<br>').replace(/\*\*(.*?)\*\*/g, '<strong>$1</strong>');
            chatBody.appendChild(botDiv);
            chatBody.scrollTop = chatBody.scrollHeight;
        })
        .catch(error => {
            console.error("Chat hatası:", error);
            var indicator = document.getElementById("typing-indicator");
            if (indicator) indicator.remove();
        });
}

// --- 3. KARANLIK MOD (DARK MODE) ENTEGRASYONU ---
function toggleTheme() {
    const isDark = document.body.classList.toggle('dark-theme');
    localStorage.setItem('theme', isDark ? 'dark' : 'light');
    updateThemeUI(isDark);
}

function updateThemeUI(isDark) {
    const icon = document.getElementById('theme-toggle-icon');
    const text = document.getElementById('theme-toggle-text');
    if (icon && text) {
        icon.innerText = isDark ? '☀️' : '🌙';
        text.innerText = isDark ? 'Aydınlık Mod' : 'Karanlık Mod';
    }
}

// Sayfa yüklendiğinde temayı uygula
document.addEventListener('DOMContentLoaded', () => {
    const savedTheme = localStorage.getItem('theme');
    const systemPrefersDark = window.matchMedia('(prefers-color-scheme: dark)').matches;
    const shouldBeDark = savedTheme === 'dark' || (!savedTheme && systemPrefersDark);

    if (shouldBeDark) {
        document.body.classList.add('dark-theme');
        updateThemeUI(true);
    } else {
        document.body.classList.remove('dark-theme');
        updateThemeUI(false);
    }
});