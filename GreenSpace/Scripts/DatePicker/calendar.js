function mod(a, b) { return a - (b * Math.floor(a / b)); }
/*
       JavaScript functions for the Fourmilab Calendar Converter

                  by John Walker  --  September, MIM
              http://www.fourmilab.ch/documents/calendar/

                This program is in the public domain.
*/
function leap_gregorian(year) {
    return ((year % 4) == 0) &&
            (!(((year % 100) == 0) && ((year % 400) != 0)));
}
var GREGORIAN_EPOCH = 1721425.5;
function gregorian_to_jd(year, month, day) {
    return (GREGORIAN_EPOCH - 1) +
           (365 * (year - 1)) +
           Math.floor((year - 1) / 4) +
           (-Math.floor((year - 1) / 100)) +
           Math.floor((year - 1) / 400) +
           Math.floor((((367 * month) - 362) / 12) +
           ((month <= 2) ? 0 :
                               (leap_gregorian(year) ? -1 : -2)
           ) +
           day);
}
function jd_to_gregorian(jd) {
    var wjd, depoch, quadricent, dqc, cent, dcent, quad, dquad,
        yindex, dyindex, year, yearday, leapadj;

    wjd = Math.floor(jd - 0.5) + 0.5;
    depoch = wjd - GREGORIAN_EPOCH;
    quadricent = Math.floor(depoch / 146097);
    dqc = mod(depoch, 146097);
    cent = Math.floor(dqc / 36524);
    dcent = mod(dqc, 36524);
    quad = Math.floor(dcent / 1461);
    dquad = mod(dcent, 1461);
    yindex = Math.floor(dquad / 365);
    year = (quadricent * 400) + (cent * 100) + (quad * 4) + yindex;
    if (!((cent == 4) || (yindex == 4))) {
        year++;
    }
    yearday = wjd - gregorian_to_jd(year, 1, 1);
    leapadj = ((wjd < gregorian_to_jd(year, 3, 1)) ? 0
                                                  :
                  (leap_gregorian(year) ? 1 : 2)
              );
    month = Math.floor((((yearday + leapadj) * 12) + 373) / 367);
    day = (wjd - gregorian_to_jd(year, month, 1)) + 1;

    return new Array(year, month, day);
}

function leap_islamic(year) {
    return (((year * 11) + 14) % 30) < 11;
}
var ISLAMIC_EPOCH = 1948439.5;
function islamic_to_jd(year, month, day) {
    return (day +
            Math.ceil(29.5 * (month - 1)) +
            (year - 1) * 354 +
            Math.floor((3 + (11 * year)) / 30) +
            ISLAMIC_EPOCH) - 1;
}
function jd_to_islamic(jd) {
    var year, month, day;

    jd = Math.floor(jd) + 0.5;
    year = Math.floor(((30 * (jd - ISLAMIC_EPOCH)) + 10646) / 10631);
    month = Math.min(12,
                Math.ceil((jd - (29 + islamic_to_jd(year, 1, 1))) / 29.5) + 1);
    day = (jd - islamic_to_jd(year, month, 1)) + 1;
    return new Array(year, month, day);
}

function leap_persian(year) {
    return ((((((year - ((year > 0) ? 474 : 473)) % 2820) + 474) + 38) * 682) % 2816) < 682;
}
var PERSIAN_EPOCH = 1948320.5;
function persian_to_jd(year, month, day) {
    var epbase, epyear;

    epbase = year - ((year >= 0) ? 474 : 473);
    epyear = 474 + mod(epbase, 2820);

    return day +
            ((month <= 7) ?
                ((month - 1) * 31) :
                (((month - 1) * 30) + 6)
            ) +
            Math.floor(((epyear * 682) - 110) / 2816) +
            (epyear - 1) * 365 +
            Math.floor(epbase / 2820) * 1029983 +
            (PERSIAN_EPOCH - 1);
}function GregorianToPersian(t, e) { if (null != t) { var r = t.split(" "), n = r[0].split("-"), a = jd_to_persian(gregorian_to_jd(parseInt(n[0]), parseInt(n[1]), parseInt(n[2]))); return CheckDate(a[0]) + "/" + CheckDate(a[1]) + "/" + CheckDate(a[2]) + " " + r[1] } return t } function GetDate(t) { if (null == t) return null; var t = t.replace(/\/Date\((.*?)\)\//gi, "$1"), e = moment().format("YYYY/MM/DD HH:mm:ss"), r = new Date(e.toString()); r.setTime(t), t = r.getFullYear() + "-" + (parseInt(r.getMonth()) + 1) + "-" + r.getDate(); var n = t.split("-"); n[0].length < 2 && (n[0] = "0" + n[0]), n[1].length < 2 && (n[1] = "0" + n[1]), n[2].length < 2 && (n[2] = "0" + n[2]); var a = r.getMinutes(); a.toString().length < 2 && (a = "0" + a); var i = r.getHours(); return i.toString().length < 2 && (i = "0" + i), t = n[0] + "-" + n[1] + "-" + n[2], t + " " + i + ":" + a } function PTG(t, e) {if ("" != t) {t = t.replace(/۰/g, "0").replace(/۱/g, "1").replace(/۲/g, "2").replace(/۳/g, "3").replace(/۴/g, "4").replace(/۵/g, "5").replace(/۶/g, "6").replace(/۷/g, "7").replace(/۸/g, "8").replace(/۹/g, "9"); t = t.replace(/-/gi, "/"); var r = t.split("/"); if ("0" == r[0][0] && (r[0] = r[0][1]), "0" == r[1][0] && (r[1] = r[1][1]), "0" == r[2][0] && (r[2] = r[2][1]), 4 == r[2].length) var n = jd_to_gregorian(persian_to_jd(parseInt(r[2]), parseInt(r[1]), parseInt(r[0]))); else var n = jd_to_gregorian(persian_to_jd(parseInt(r[0]), parseInt(r[1]), parseInt(r[2]))); var a = CheckDate(n[0]) + "/" + CheckDate(n[1]) + "/" + CheckDate(n[2]); return null == e || void 0 == e ? a.split(" ")[0] : a}} function CheckDate(t) { return t.toString().length < 2 && (t = "0" + t), t }function jd_to_persian(jd) {var year, month, day, depoch, cycle, cyear, ycycle,aux1, aux2, yday;jd = Math.floor(jd) + 0.5;depoch = jd - persian_to_jd(475, 1, 1);cycle = Math.floor(depoch / 1029983);cyear = mod(depoch, 1029983);if (cyear == 1029982) {ycycle = 2820;} else {aux1 = Math.floor(cyear / 366);aux2 = mod(cyear, 366);ycycle = Math.floor(((2134 * aux1) + (2816 * aux2) + 2815) / 1028522) +aux1 + 1;}year = ycycle + (2820 * cycle) + 474;if (year <= 0) {year--;}yday = (jd - persian_to_jd(year, 1, 1)) + 1;month = (yday <= 186) ? Math.ceil(yday / 31) : Math.ceil((yday - 6) / 30);day = (jd - persian_to_jd(year, month, 1)) + 1;return new Array(year, month, day);
}
