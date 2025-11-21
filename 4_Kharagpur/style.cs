    * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        body {
            background: linear-gradient(135deg, #1a2a6c, #b21f1f, #fdbb2d);
            color: #333;
            line-height: 1.6;
            min-height: 100vh;
            padding-bottom: 50px;
        }

        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }

        header {
            text-align: center;
            padding: 40px 20px;
            color: white;
            position: relative;
            overflow: hidden;
            border-radius: 15px;
            margin-bottom: 30px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.3);
        }

        header::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: rgba(0, 0, 0, 0.4);
            z-index: 1;
        }

        .header-content {
            position: relative;
            z-index: 2;
        }

        .logo {
            height: 100px;
            margin-bottom: 20px;
            filter: drop-shadow(0 0 10px rgba(255, 255, 255, 0.5));
        }

        h1 {
            font-size: 2.8rem;
            margin-bottom: 10px;
            text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.5);
        }

        .subtitle {
            font-size: 1.5rem;
            margin-bottom: 20px;
            font-weight: 300;
            text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.5);
        }

        .intro {
            max-width: 900px;
            margin: 0 auto 30px;
            font-size: 1.1rem;
            line-height: 1.8;
            text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.5);
        }

        .faculty-container {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
            gap: 30px;
            margin-top: 30px;
        }

        .faculty-card {
            background: rgba(255, 255, 255, 0.95);
            border-radius: 15px;
            overflow: hidden;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);
            transition: transform 0.3s ease, box-shadow 0.3s ease;
        }

        .faculty-card:hover {
            transform: translateY(-10px);
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.3);
        }

        .faculty-img {
            width: 100%;
            height: 300px;
            object-fit: cover;
            border-bottom: 4px solid #1a2a6c;
        }

        .faculty-content {
            padding: 25px;
        }

        .faculty-name {
            font-size: 1.8rem;
            color: #1a2a6c;
            margin-bottom: 5px;
            border-bottom: 2px solid #fdbb2d;
            padding-bottom: 10px;
        }

        .faculty-position {
            color: #b21f1f;
            font-size: 1.1rem;
            margin-bottom: 15px;
            font-weight: 600;
        }

        .section-title {
            font-size: 1.3rem;
            color: #1a2a6c;
            margin: 20px 0 10px;
            padding-bottom: 5px;
            border-bottom: 1px solid #eee;
        }

        .highlights-list {
            padding-left: 20px;
            margin: 10px 0;
        }

        .highlights-list li {
            margin-bottom: 8px;
        }

        .dispute-section {
            background: rgba(255, 255, 255, 0.95);
            border-radius: 15px;
            padding: 30px;
            margin: 40px 0;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);
        }

        .perspectives {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 20px;
            margin-top: 20px;
        }

        .perspective-card {
            background: #f8f9fa;
            padding: 20px;
            border-radius: 10px;
            border-left: 4px solid #1a2a6c;
        }

        .perspective-title {
            font-size: 1.2rem;
            color: #1a2a6c;
            margin-bottom: 10px;
            font-weight: 600;
        }

        .nav-buttons {
            display: flex;
            gap: 20px;
            justify-content: center;
            margin-top: 40px;
            flex-wrap: wrap;
        }

        .nav-button {
            display: inline-flex;
            align-items: center;
            gap: 10px;
            background: rgba(255, 255, 255, 0.2);
            color: white;
            padding: 12px 24px;
            border-radius: 25px;
            text-decoration: none;
            transition: all 0.3s ease;
            backdrop-filter: blur(10px);
            border: 1px solid rgba(255, 255, 255, 0.3);
            font-weight: 600;
        }

        .nav-button:hover {
            background: rgba(255, 255, 255, 0.3);
            transform: translateY(-3px);
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.2);
        }

        footer {
            text-align: center;
            margin-top: 50px;
            color: rgba(255, 255, 255, 0.7);
            font-size: 0.9rem;
        }

        @media (max-width: 768px) {
            h1 {
                font-size: 2.2rem;
            }
            
            .subtitle {
                font-size: 1.2rem;
            }
            
            .faculty-container {
                grid-template-columns: 1fr;
            }
            
            .nav-buttons {
                flex-direction: column;
                align-items: center;
            }
            
            .nav-button {
                width: 80%;
                justify-content: center;
            }
        }
    