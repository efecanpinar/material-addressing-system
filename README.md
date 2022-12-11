# adresleme sistemi

Fiziki nesneleri depolarda adreslemek amacıyla geliştirdiğim otomasyon projesi. Temel hiyerarşi şu adımlar üzerine kuruludur:

Depo -> Koridor -> Dolap -> Raf -> Hücre -> Nesne

Bir deponun birden fazla koridoru olabilir.
Bir koridorun bir deposu olabilir.

Bir koridorun birden fazla dolabı olabilir.
Bir dolabın bir koridoru olabilir.

Bir dolabın birden fazla rafı olabilir.
Bir rafın bir dolabı olabilir.

Bir rafın birden fazla hücresi olabilir.
Bir hücrenin bir rafı olabilir.

Bir nesnenin birden fazla hücresi olabilir.
Bir hücrenin bir nesnesi olabilir.

Temel olarak Depo Tanımı, Koridor Tanımı, Dolap Tanımı, Raf Tanımı, Hücre Tanımı ve Nesne Tanımı ekranlarını içerir.
