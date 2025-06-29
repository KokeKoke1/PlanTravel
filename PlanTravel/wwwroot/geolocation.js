window.getUserCity = async () => {
    return new Promise((resolve, reject) => {
        if (!navigator.geolocation) {
            reject("UNSUPPORTED");
            return;
        }

        navigator.geolocation.getCurrentPosition(
            async (position) => {
                const lat = position.coords.latitude;
                const lon = position.coords.longitude;

                try {
                    const response = await fetch(`https://nominatim.openstreetmap.org/reverse?format=jsonv2&lat=${lat}&lon=${lon}`);
                    const data = await response.json();
                    resolve(data.address.city || data.address.town || data.address.village || "Nieznana lokalizacja");
                } catch (error) {
                    reject("GEOCODING_FAILED");
                }
            },
            (error) => {
                switch (error.code) {
                    case error.PERMISSION_DENIED:
                        reject("PERMISSION_DENIED");
                        break;
                    case error.POSITION_UNAVAILABLE:
                        reject("POSITION_UNAVAILABLE");
                        break;
                    case error.TIMEOUT:
                        reject("TIMEOUT");
                        break;
                    default:
                        reject("UNKNOWN_ERROR");
                        break;
                }
            }
        );
    });
};
