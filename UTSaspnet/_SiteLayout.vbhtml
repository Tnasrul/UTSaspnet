<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>@PageData("Title") </title>
    <meta name="viewport" content="width=device-width" />
    <link rel="canonical" href="https://getbootstrap.com/docs/5.1/examples/headers/">
    <link href="~/Content/themes/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <header class="p-3 bg-dark text-white">
        <div class="container">
            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                
                <ul class="nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    <li><a href="~/Default.vbhtml" class="nav-link px-2 text-secondary">Home</a></li>
                    <li><a href="~/About.vbhtml" class="nav-link px-2 text-white">Harga Pasar Terkini</a></li>
                    <li><a href="~/Contact.vbhtml" class="nav-link px-2 text-white">Input Hasil Survey Terbaru</a></li>
                    
                </ul>

                <form class="col-12 col-lg-auto mb-3 mb-lg-0 me-lg-3">
                    <input type="search" class="form-control form-control-dark" placeholder="Cari Barang..." aria-label="Search">
                </form>

                <div class="text-end">                    
                    <button type="button" class="btn btn-warning">Cari</button>
                </div>
            </div>
        </div>
    </header>
    <div id="body">
        @RenderSection("featured", required:=False)
        <section class="content-wrapper main-content clear-fix">
            @RenderBody()
        </section>
    </div>
    <footer class="text-muted py-5">
        <div class="container">
            <p class="float-end mb-1">
                <a href="#">Back to top</a>
            </p>
            <p class="mb-1">Album example is &copy; Bootstrap, but please download and customize it for yourself!</p>
            <p class="mb-0">New to Bootstrap? <a href="/">Visit the homepage</a> or read our <a href="../getting-started/introduction/">getting started guide</a>.</p>
        </div>
    </footer>
    <script src="~/Content/themes/bootstrap/dist/js/bootstrap.bundle.min.js"></script>

    @RenderSection("Scripts", required:=False)
</body>
</html>