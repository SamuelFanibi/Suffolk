import axios from 'axios'
export const fetchPeople = async () => {
    try {
        const response = await axios
            .get('/person/GetPeople');
        return response.data;

    } catch (err) {
        return [];
    }
}