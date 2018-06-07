var titulo = document.getElementById("tit").innerHTML;
var latitud = parseInt(document.getElementById("lat").innerHTML);
var longitud = parseInt(document.getElementById("lon").innerHTML);
var zoomv = parseInt(document.getElementById("zoom").innerHTML);

latitud = 40.420377;
longitud = -3.703494;

var map;
var marker;

var clickMarker = null;
function initMap() {

    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: latitud, lng: longitud },
        zoom: 15
        , styles: [
            {
                featureType: 'all',
                stylers: [
                  { saturation: -80 }
                ]
            }, {
                featureType: 'road.arterial',
                elementType: 'geometry',
                stylers: [
                  { hue: '#00ffee' },
                  { saturation: 50 }
                ]
            }, {
                featureType: 'poi.business',
                elementType: 'labels',
                stylers: [
                  { visibility: 'on' }
                ]
            }
        ]
    });

    marker = new google.maps.Marker({ position: { lat: latitud, lng: longitud }, map: map, title: titulo });

    map.addListener('click', function (e) {
        infowindow.open(map, marker);
    });
}

$(document).ready(function () {
    initMap();
});