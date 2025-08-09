import { defineConfig } from 'vite';
import plugin from '@vitejs/plugin-react';

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [plugin()],
    server: {
        port: 56627,
        proxy: {
            '/api': {
                target: 'http://localhost:5000',
                secure: false
            }
        }
    }
})
