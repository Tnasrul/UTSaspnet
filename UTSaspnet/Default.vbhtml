@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "Home Page"
End Code
<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Hugo 0.88.1">
    <title>Product example · Bootstrap v5.1</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/5.1/examples/product/">



    <!-- Bootstrap core CSS -->
    <link href="~/Content/themes/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        user-select: none;
      }


    </style>


    <!-- Custom styles for this template -->
    <link href="product.css" rel="stylesheet">
</head>
<body>

    <div class="container">
        
        <div class="nav-scroller py-1 mb-2 ">
            
        </div>
    </div>

    <main class="container">
        <div class="p-4 p-md-5 mb-4 text-black rounded bg-white">                                      
                <h1 class="display-4 fst-italic fw-bold">Selamat Datang Di Website Kami</h1>
                <p class="lead my-3">Ini Adalah Website Survei Harga Pangan Pasar</p>
            
        </div>

        <div class="row mb-2">
            <div class="col-md-6">
                <div class="row g-0 border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative">
                    <div class="col p-4 d-flex flex-column position-static">
                        <strong class="d-inline-block mb-2 text-primary">Harga Pasar Terbaru</strong>
                        <h3 class="mb-0">Survey Kami</h3>
                        
                        <p class="card-text mb-auto">disini kamu akan mendapatkan informasi tentang harga pasar terbaru.</p>
                        <a href="~/About.vbhtml" class="stretched-link">Lihat...</a>
                    </div>
                    <div class="col-auto d-none d-lg-block">
                        <img src="~/Images/b.jpg" width="200" height="250" class="bd-placeholder-img" alt="..." />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row g-0 border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative">
                    <div class="col p-4 d-flex flex-column position-static">
                        <strong class="d-inline-block mb-2 text-primary">Harga Pasar Menurut Mu</strong>
                        <h3 class="mb-0">Input Harga</h3>
                        
                        <p class="mb-auto">Jika kamu mempunyai update harga pasar terbaru silahkan klik link di bawah ini.</p>
                        <a href="~/Contact.vbhtml" class="stretched-link">Lihat...</a>
                    </div>
                    <div class="col-auto d-none d-lg-block">
                        <img src="~/Images/a.jpg" width="200" height="250" class="bd-placeholder-img" alt="..." />

                    </div>
                </div>
            </div>
        </div>
    </main>


</body>
</html>
