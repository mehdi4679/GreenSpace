/*
* Elements that make up the popup.
*/
var container = document.getElementById('popup');
var content = document.getElementById('popup-content');
var closer = document.getElementById('popup-closer');


/**
 * Create an overlay to anchor the popup to the map.
 */
var overlay = new ol.Overlay(/** @type {olx.OverlayOptions} */({
    element: container,
    autoPan: true,
    autoPanAnimation: {
        duration: 250
    }
}));

/**
  * Add a click handler to hide the popup.
  * @return {boolean} Don't follow the href.
  */
closer.onclick = function () {
    overlay.setPosition(undefined);
    closer.blur();
    return false;
};



// مشخص کردن پراجکشن نقشه
var projection = new ol.proj.Projection({
    code: 'EPSG:32639',
    units: 'm'
});


var popup2 = new ol.Overlay({
    element: document.getElementById('popup2')
});

////////http://192.168.200.25:6080/arcgis/rest/services/treebon/MapServer

// دریافت نقشه از لایه های مپ سرور	
//var layers = [
//    new ol.layer.Image({
//        extent: [462465, 3820270, 514830, 3848007],
//        source: new ol.source.ImageWMS({
//            url: 'http://localhost:8070/cgi-bin/mapserv.exe?map=C:/ms4w/apps/ms101/htdocs/wms.map',
//            params: {
//                'LAYERS': 'line1,line2,line3,line4,line5,line6,poly1',
//                'CRS': 'EPSG:32639',
//                'BBOX': '462465,3820270,514830,3848007',
//                'WIDTH': '800',
//                'HEIGHT': '500',
//                'FORMAT': 'image/png'
//            },
//            serverType: 'mapserver'
//        })
//    })
//];

//var layers = [
//new ol.layer.Tile({
//    source: new ol.source.OSM()
//})
//];

var map = new ol.Map({
    target: 'map',
    overlays: [overlay, popup2],
    layers: [
    new ol.layer.Tile({
        source: new ol.source.OSM()
    })
    ],
    view: new ol.View({
        center: ol.proj.transform([50.8759, 34.6399], 'EPSG:4326', 'EPSG:3857'),
        zoom: 12
    })
});






//ایجاد ویو و نقطه مرکزی نقشه
//var view = new ol.View({
//    center: [489152, 3833514],
//    zoom: 16,
//    projection: projection
//});


// ساخت نقشه
//var map = new ol.Map({
//    layers: layers,
//    target: 'map',
//    controls: ol.control.defaults({
//        zoom: true,
//        attribution: true,
//        rotate: true
//    })
//});

//map.setView(view);


//افزودن لایه برای نمایش تگ بر روی نقشه
map.addOverlay(popup2);





////افزودن قابلیت تعیین منطقه ای موس روی آن است///////////////////
//var mousePosition = new ol.control.MousePosition({
//    coordinateFormat: ol.coordinate.createStringXY(2),
//    projection: 'EPSG:32639',
//    target: document.getElementById('myposition'),
//    undefinedHTML: '&nbsp;'
//});
//map.addControl(mousePosition);
//////////////////////////////////////////////////////////////////
///// افزودن اکسل بار در پایین نقشه
//var sss = new ol.control.ScaleLine({
//    units: 'degrees',
//    minWidth: 100
//});
//map.addControl(sss);



var container = document.getElementById('popup2');
var bCordinate;


//////////////////////////////////////////////////////////
//برای کلیک بر روی نقشه و دریافت طول و عرض جغرافیایی باید ابتدا قابلیت کلیک را تعریف کنید
map.on('click', function (evt) {
    var coordinate = evt.coordinate; // دریافت نطقه کلیک شدخ
    bCordinate = evt.coordinate;

    /// با این بخش میتونید اطلاعات لایه هایی که تو اون نقطه هست را بیرون بیاری
    var region;
    var area;
    var sector;
    var features = [];

    //این حلقه تمام لایه های زیر را بدست میاره
    //map.forEachFeatureAtPixel(evt.pixel, function (feature, layer) {
    //    features.push(feature);
    //});

    //region = features[0].get('Region');  //منطقه
    //area = features[0].get('Area');      // ناحیه
    //sector = features[0].get('Sector');  // محله

    console.log('coordinate:' + coordinate);
    //console.log('region:' + region);
    //console.log('area:' + area);
    //console.log('sector:' + sector);

    //این بخش یه نگ تو نقطه ای که کلیک شده میزنه
    popup2.setPosition(coordinate);
    container.innerHTML = '<img src="Scripts/ol/mappin.png" style="margin-left: -5px;margin-top:-17px; " />';
    //

    //ساخت نطقه به فرمت اس  کیو ال
    var sqlPoint = "POINT(" + coordinate[0] + " " + coordinate[1] + ")"

    overlay.setPosition(coordinate);

    //alert(sqlPoint);
    // حالا میتونی متغیر بالا ره به یه صفحه دیگه بصور کوئری استرینگ بفرستی و اطلاعات دیگه را توی او صفحه بگیری - متونی با یه دستور جی کوئری پنجره باز کنی

});








