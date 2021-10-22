@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "Contact"
End Code
<div class="col-lg-8 mx-auto p-3 py-md-5">
    <h4 class="mb-3">Input Harga</h4>
    <form class="needs-validation" novalidate>
        <div class="row g-3">
            <div class="col-sm-12">
                <label for="firstName" class="form-label">Tanggal</label>
                <input type="datetime-local" class="form-control" id="firstName" placeholder="" value="" required>
                <div class="invalid-feedback">
                    Valid first name is required.
                </div>
            </div>

            <div class="col-sm-12">
                <label for="Barang" class="form-label">Barang</label>
                <input type="text" class="form-control" id="Barang" placeholder="" value="" required>
                <div class="invalid-feedback">
                    Masukan Nama Barang.
                </div>
            </div>
            <div class="col-sm-12">
                <label for="Harga" class="form-label">Harga</label>
                <input type="text" class="form-control" id="Harga" placeholder="" value="" required>
                <div class="invalid-feedback">
                    Masukan Harga.
                </div>
            </div>
        </div>
            <hr class="my-4">

            <button class="w-100 btn btn-warning btn-lg" type="submit">Input</button>
    </form>
</div>