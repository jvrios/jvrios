import axios from 'axios';

const GIPHY_API_KEY = '0j8PaMDFtQmKu6VupE3Fu423glu8QmTG'; // Replace with your actual Giphy API key
const GIPHY_API_URL = 'https://api.giphy.com/v1/gifs/search';

const searchGifs = async (query, limit = 20) => {
  const response = await axios.get(GIPHY_API_URL, {
    params: {
      api_key: GIPHY_API_KEY,
      q: query,
      limit: limit
    }
  });
  return response.data;
};

export default { searchGifs };
