<%@ Page Title="" Language="C#" MasterPageFile="~/Main_clinic.Master" AutoEventWireup="true" CodeBehind="index_home.aspx.cs" Inherits="Clinic_project.index_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    html, body {
        height: 100%;
        margin: 0;
        padding: 0;
        display: flex;
        flex-direction: column;
    }

    /* Main content area grows to fill space */
    #ContentPlaceHolder1 {
        flex: 1 0 auto;
    }

    footer {
        flex-shrink: 0; /* Footer stays at bottom */
    }

    /* Optional: make carousel taller */
    .carousel-img {
        height: 500px;
        object-fit: cover;
        width: 100%;
    }

    @media (max-width: 768px) {
        .carousel-img {
            height: 300px;
        }
    }

    .carousel-caption-bg {
        background-color: rgba(0, 0, 0, 0.5);
        padding: 15px;
        border-radius: 10px;
        box-shadow: 0 0 15px rgba(0, 0, 0, 0.4);
    }
</style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel" data-bs-interval="2000">
        <div class="carousel-indicators">
            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
            <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
        </div>

        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="images/cfirst.png" class="d-block w-100 carousel-img" alt="Clinic Front View">
                <div class="carousel-caption d-none d-md-block">
                    <div class="carousel-caption-bg">
                        <h5>Welcome to Our Clinic</h5>
                        <p>Providing quality healthcare with expert doctors and modern facilities.</p>
                    </div>
                </div>
            </div>

            <div class="carousel-item">
                <img src="images/csecond.jpg" class="d-block w-100 carousel-img" alt="Doctor Consultation">
                <div class="carousel-caption d-none d-md-block">
                    <div class="carousel-caption-bg">
                        <h5>Expert Medical Care</h5>
                        <p>Our experienced doctors ensure personalized care for every patient.</p>
                    </div>
                </div>
            </div>

            <div class="carousel-item">
                <img src="images/cthird.jpg" class="d-block w-100 carousel-img" alt="Advanced Equipment">
                <div class="carousel-caption d-none d-md-block">
                    <div class="carousel-caption-bg">
                        <h5>State-of-the-Art Facilities</h5>
                        <p>Equipped with modern diagnostic tools and a patient-friendly environment.</p>
                    </div>
                </div>
            </div>
        </div>

        <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>

</asp:Content>
