function calcCone(r, h) {
    let volume = (1 / 3) * Math.PI * (r * r) * h;
    let slantHeight = Math.sqrt((r * r) + (h * h));
    let lateralSurfaceArea = Math.PI*r*slantHeight;
    let baseSurfaceArea = Math.PI * (r * r);
    let totalArea = lateralSurfaceArea+ baseSurfaceArea;
    console.log(volume.toFixed(4));
    console.log(totalArea.toFixed(4));
}

calcCone(3, 5);