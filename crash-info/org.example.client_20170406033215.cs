S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 8965
Date: 2017-04-06 03:32:15+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 8965, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00002305
r2   = 0x00000006, r3   = 0xb40c34c0
r4   = 0x00000002, r5   = 0xb40c3000
r6   = 0xb67bd09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5eeb708
r10  = 0xb7e7c940, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbebdcecc
lr   = 0xb66b3f18, pc   = 0xb66b2b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:     79264 KB
Buffers:     61256 KB
Cached:     286524 KB
VmPeak:     133796 KB
VmSize:     133792 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28196 KB
VmRSS:       28196 KB
VmData:      45740 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35776 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8965 TID = 8965
8965 8966 9026 9027 9039 

Maps Information
af1ec000 af9eb000 rw-p [stack:9039]
b0f6a000 b0f7b000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f8b000 b0f90000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1392000 b139a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13ac000 b1bab000 rw-p [stack:9027]
b1bab000 b1bac000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bbc000 b1bd0000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1be4000 b1be5000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf5000 b1bf8000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c09000 b1c0a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c1a000 b1c1c000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c2c000 b1c2e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c3e000 b1c4e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c5e000 b1c6a000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c7c000 b247b000 rw-p [stack:9026]
b27ac000 b27b3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c6000 b27cc000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27dc000 b27f7000 r-xp /opt/usr/apps/org.example.client/bin/client
b294f000 b2a32000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a69000 b2a91000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aa3000 b32a2000 rw-p [stack:8966]
b32a2000 b32a4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32b4000 b32be000 r-xp /lib/libnss_files-2.20-2014.11.so
b32cf000 b32d8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32e9000 b32fa000 r-xp /lib/libnsl-2.20-2014.11.so
b330d000 b3313000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3324000 b3325000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b334d000 b3354000 r-xp /usr/lib/libminizip.so.1.0.0
b3364000 b3369000 r-xp /usr/lib/libstorage.so.0.1
b3379000 b33d8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33ee000 b3402000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3412000 b3456000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3466000 b346e000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b347e000 b34ae000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34c1000 b357a000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b358e000 b35e1000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35f2000 b360d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b361d000 b36de000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36f1000 b3701000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3711000 b371e000 r-xp /usr/lib/libmdm-common.so.1.0.98
b372f000 b3736000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3746000 b3787000 r-xp /usr/lib/libmdm.so.1.2.12
b3797000 b379f000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37ae000 b37be000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37df000 b383f000 r-xp /usr/lib/libasound.so.2.0.0
b3851000 b3854000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3864000 b3867000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3877000 b387c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b388c000 b388d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b389d000 b38a8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38bc000 b38c3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38d3000 b38d9000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38e9000 b38ee000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38fe000 b3919000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3929000 b3930000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3940000 b3943000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3954000 b3982000 r-xp /usr/lib/libidn.so.11.5.44
b3992000 b39a8000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39b9000 b39c3000 r-xp /usr/lib/libcares.so.2.1.0
b39d3000 b39dd000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39ed000 b39ef000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ff000 b3a00000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a10000 b3a14000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a25000 b3a4d000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a5e000 b3a87000 r-xp /usr/lib/libturbojpeg.so
b3aa7000 b3aad000 r-xp /usr/lib/libgif.so.4.1.6
b3abd000 b3b03000 r-xp /usr/lib/libcurl.so.4.3.0
b3b14000 b3b35000 r-xp /usr/lib/libexif.so.12.3.3
b3b50000 b3b65000 r-xp /usr/lib/libtts.so
b3b76000 b3b7e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b8e000 b3c54000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c74000 b3d6c000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d8b000 b3e59000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e70000 b3e72000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e82000 b3e88000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e98000 b3ebb000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ecc000 b3ece000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ede000 b3ee0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ef1000 b3ef6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f0d000 b3f0f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f1f000 b3f26000 r-xp /usr/lib/libsensord-share.so
b3f36000 b3f4e000 r-xp /usr/lib/libsensor.so.1.1.0
b3f5f000 b3f62000 r-xp /usr/lib/libXv.so.1.0.0
b3f72000 b3f77000 r-xp /usr/lib/libutilX.so.1.1.0
b3f87000 b3f8c000 r-xp /usr/lib/libappcore-common.so.1.1
b3f9c000 b3fa3000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fb6000 b3fba000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fcb000 b40a9000 r-xp /usr/lib/libCOREGL.so.4.0
b40c9000 b40cc000 r-xp /usr/lib/libuuid.so.1.3.0
b40dc000 b40f3000 r-xp /usr/lib/libblkid.so.1.1.0
b4104000 b4106000 r-xp /usr/lib/libXau.so.6.0.0
b4116000 b415d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b416f000 b4175000 r-xp /usr/lib/libjson-c.so.2.0.1
b4186000 b418a000 r-xp /usr/lib/libogg.so.0.7.1
b419a000 b41bc000 r-xp /usr/lib/libvorbis.so.0.4.3
b41cc000 b42b0000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42cc000 b42cf000 r-xp /usr/lib/libEGL.so.1.4
b42e0000 b42e6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42f6000 b42f8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4308000 b4315000 r-xp /usr/lib/libGLESv2.so.2.0
b4326000 b4388000 r-xp /usr/lib/libpixman-1.so.0.28.2
b439d000 b43b5000 r-xp /usr/lib/libmount.so.1.1.0
b43c7000 b43db000 r-xp /usr/lib/libxcb.so.1.1.0
b43eb000 b43f2000 r-xp /lib/libcrypt-2.20-2014.11.so
b442a000 b442c000 r-xp /usr/lib/libiri.so
b443c000 b4447000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4458000 b448e000 r-xp /usr/lib/libpulse.so.0.16.2
b449f000 b44e2000 r-xp /usr/lib/libsndfile.so.1.0.25
b44f7000 b450c000 r-xp /lib/libexpat.so.1.5.2
b451e000 b45dc000 r-xp /usr/lib/libcairo.so.2.11200.14
b45f0000 b45f8000 r-xp /usr/lib/libdrm.so.2.4.0
b4608000 b460b000 r-xp /usr/lib/libdri2.so.0.0.0
b461b000 b4669000 r-xp /usr/lib/libssl.so.1.0.0
b467e000 b468a000 r-xp /usr/lib/libeeze.so.1.13.0
b469b000 b46a4000 r-xp /usr/lib/libethumb.so.1.13.0
b46b4000 b46b7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46c7000 b487e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5669000 b5672000 r-xp /usr/lib/libXi.so.6.1.0
b5682000 b5684000 r-xp /usr/lib/libXgesture.so.7.0.0
b5694000 b5698000 r-xp /usr/lib/libXtst.so.6.1.0
b56a8000 b56ae000 r-xp /usr/lib/libXrender.so.1.3.0
b56be000 b56c4000 r-xp /usr/lib/libXrandr.so.2.2.0
b56d4000 b56d6000 r-xp /usr/lib/libXinerama.so.1.0.0
b56e7000 b56ea000 r-xp /usr/lib/libXfixes.so.3.1.0
b56fa000 b5705000 r-xp /usr/lib/libXext.so.6.4.0
b5715000 b5717000 r-xp /usr/lib/libXdamage.so.1.1.0
b5727000 b5729000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5739000 b581b000 r-xp /usr/lib/libX11.so.6.3.0
b582f000 b5836000 r-xp /usr/lib/libXcursor.so.1.0.2
b5846000 b585e000 r-xp /usr/lib/libudev.so.1.6.0
b5860000 b5863000 r-xp /lib/libattr.so.1.1.0
b5873000 b5893000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5894000 b5899000 r-xp /usr/lib/libffi.so.6.0.2
b58aa000 b58c2000 r-xp /lib/libz.so.1.2.8
b58d2000 b58d4000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58e4000 b59b9000 r-xp /usr/lib/libxml2.so.2.9.2
b59ce000 b5a69000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a85000 b5a88000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a98000 b5ab1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ac2000 b5ad3000 r-xp /lib/libresolv-2.20-2014.11.so
b5ae7000 b5b61000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b76000 b5b78000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b88000 b5b8f000 r-xp /usr/lib/libembryo.so.1.13.0
b5b9f000 b5ba9000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bba000 b5bd2000 r-xp /usr/lib/libpng12.so.0.50.0
b5be3000 b5c06000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c27000 b5c3b000 r-xp /usr/lib/libector.so.1.13.0
b5c4c000 b5c64000 r-xp /usr/lib/liblua-5.1.so
b5c75000 b5ccc000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ce0000 b5d08000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d19000 b5d2c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d3d000 b5d77000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d88000 b5d96000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5da6000 b5dae000 r-xp /usr/lib/libtbm.so.1.0.0
b5dbe000 b5dcb000 r-xp /usr/lib/libeio.so.1.13.0
b5ddb000 b5ddd000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5ded000 b5df2000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e02000 b5e19000 r-xp /usr/lib/libefreet.so.1.13.0
b5e2b000 b5e4b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e5b000 b5e7b000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e7d000 b5e83000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e93000 b5ea4000 r-xp /usr/lib/libemotion.so.1.13.0
b5eb5000 b5ebc000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ecc000 b5edb000 r-xp /usr/lib/libeo.so.1.13.0
b5eec000 b5efe000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f0f000 b5f14000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f24000 b5f3d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f4d000 b5f6a000 r-xp /usr/lib/libeet.so.1.13.0
b5f83000 b5fcb000 r-xp /usr/lib/libeina.so.1.13.0
b5fdc000 b5fec000 r-xp /usr/lib/libefl.so.1.13.0
b5ffd000 b60e2000 r-xp /usr/lib/libicuuc.so.51.1
b60ff000 b623f000 r-xp /usr/lib/libicui18n.so.51.1
b6256000 b628e000 r-xp /usr/lib/libecore_x.so.1.13.0
b62a0000 b62a3000 r-xp /lib/libcap.so.2.21
b62b3000 b62dc000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62ed000 b62f4000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6306000 b633d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b634e000 b6439000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b644c000 b64c5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64d7000 b64dc000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64ec000 b64f6000 r-xp /usr/lib/libvconf.so.0.2.45
b6506000 b6508000 r-xp /usr/lib/libvasum.so.0.3.1
b6518000 b651a000 r-xp /usr/lib/libttrace.so.1.1
b652a000 b652d000 r-xp /usr/lib/libiniparser.so.0
b653d000 b6563000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6573000 b6578000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6589000 b65a0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65b1000 b661c000 r-xp /lib/libm-2.20-2014.11.so
b662d000 b6633000 r-xp /lib/librt-2.20-2014.11.so
b6644000 b6651000 r-xp /usr/lib/libunwind.so.8.0.1
b6687000 b67ab000 r-xp /lib/libc-2.20-2014.11.so
b67c0000 b67d9000 r-xp /lib/libgcc_s-4.9.so.1
b67e9000 b68cb000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68dc000 b6906000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6917000 b6953000 r-xp /usr/lib/libsystemd.so.0.4.0
b6955000 b69d8000 r-xp /usr/lib/libedje.so.1.13.0
b69eb000 b6a09000 r-xp /usr/lib/libecore.so.1.13.0
b6a29000 b6bb0000 r-xp /usr/lib/libevas.so.1.13.0
b6be5000 b6bf9000 r-xp /lib/libpthread-2.20-2014.11.so
b6c0d000 b6e41000 r-xp /usr/lib/libelementary.so.1.13.0
b6e70000 b6e74000 r-xp /usr/lib/libsmack.so.1.0.0
b6e84000 b6e8b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e9b000 b6e9d000 r-xp /usr/lib/libdlog.so.0.0.0
b6ead000 b6eb0000 r-xp /usr/lib/libbundle.so.0.1.22
b6ec0000 b6ec2000 r-xp /lib/libdl-2.20-2014.11.so
b6ed3000 b6eeb000 r-xp /usr/lib/libaul.so.0.1.0
b6eff000 b6f04000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f15000 b6f22000 r-xp /usr/lib/liblptcp.so
b6f34000 b6f38000 r-xp /usr/lib/libsys-assert.so
b6f49000 b6f69000 r-xp /lib/ld-2.20-2014.11.so
b6f7a000 b6f7f000 r-xp /usr/bin/launchpad-loader
b7af9000 b7ed8000 rw-p [heap]
bebbd000 bebde000 rw-p [stack]
bebbd000 bebde000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8965)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb66b2b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 wrap=mixed linegap=-3'
04-06 03:29:35.297+0900 W/HOME_APPS(  858): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-06 03:29:36.639+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-06 03:29:36.639+0900 E/PKGMGR_SERVER( 8821): pkgmgr-server.c: main(2471) > package manager server terminated.
04-06 03:29:39.672+0900 W/AUL     ( 8879): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-06 03:29:39.672+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-06 03:29:39.682+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-06 03:29:39.692+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-06 03:29:39.692+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-06 03:29:39.692+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 8879
04-06 03:29:39.692+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-06 03:29:39.702+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:29:39.702+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:29:39.712+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 03:29:39.712+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 03:29:39.712+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 03:29:39.732+0900 I/abc     ( 8257): abc
04-06 03:29:39.732+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:29:39.732+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:29:39.762+0900 E/TBM     ( 8257): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:29:39.812+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8257, appid: org.example.client
04-06 03:29:39.812+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:29:39.812+0900 W/AUL     ( 8879): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8257)
04-06 03:29:40.022+0900 D/basicui ( 8257): successed to load edc file
04-06 03:29:40.052+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:40.052+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:40.072+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:29:40.072+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:40.072+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:40.092+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:40.112+0900 I/MY_LOG  ( 8257): change
04-06 03:29:40.152+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(514) > [APP 8257] Event: RESET State: CREATED
04-06 03:29:40.152+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:29:40.162+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.162+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.172+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.172+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.172+0900 E/EFL     ( 8257): edje<8257> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:29:40.172+0900 E/EFL     ( 8257): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:29:40.182+0900 W/APP_CORE( 8257): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200002
04-06 03:29:40.182+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:29:40.282+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:29:40.282+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:29:40.282+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:29:40.292+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:29:40.292+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8257) status(3)
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:29:40.292+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:29:40.292+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(8257)
04-06 03:29:40.292+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8257, appid: org.example.client, status: fg
04-06 03:29:40.292+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(514) > [APP 8257] Event: RESUME State: CREATED
04-06 03:29:40.312+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:29:40.312+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:29:40.312+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:29:40.312+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:29:40.312+0900 I/APP_CORE( 8257): appcore-efl.c: __do_app(625) > [APP 8257] Initial Launching, call the resume_cb
04-06 03:29:40.312+0900 I/CAPI_APPFW_APPLICATION( 8257): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:29:40.663+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8257) status(0)
04-06 03:29:40.873+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2014
04-06 03:29:40.883+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 03:29:40.883+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 8257.
04-06 03:29:41.644+0900 I/UXT     ( 8892): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 03:29:42.995+0900 E/EFL     ( 8257): ecore_x<8257> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=214902361
04-06 03:29:42.995+0900 I/MY_LOG  ( 8257): Button pressed
04-06 03:29:43.105+0900 E/EFL     ( 8257): ecore_x<8257> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=214902471
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: vconf_get_bool(2729) > vconf_get_bool(8257) : db/ise/keysound error
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:29:43.105+0900 E/VCONF   ( 8257): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:29:43.165+0900 I/MY_LOG  ( 8257): Button unpressed
04-06 03:29:43.295+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8257 pgid = 8257
04-06 03:29:43.295+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(8257)
04-06 03:29:43.295+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:29:43.315+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:29:43.325+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:29:43.325+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:29:43.355+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:29:43.355+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:29:43.355+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:29:43.355+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[8257] terminate event is forwarded
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 8257, ]
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:29:43.365+0900 I/Tizen::App( 1231): (512) > Not registered pid(8257)
04-06 03:29:43.365+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:29:43.365+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:43.365+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 8257
04-06 03:29:43.365+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8257
04-06 03:29:43.365+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8257
04-06 03:29:43.375+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:29:43.375+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:29:43.375+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:29:43.375+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:29:43.385+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:29:43.415+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:43.415+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 8257.
04-06 03:29:43.415+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:29:43.425+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:29:43.425+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:29:43.455+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:29:43.465+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b450c8]
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:29:43.475+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b450c8
04-06 03:29:43.475+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:29:43.475+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:29:43.475+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:29:43.485+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:29:43.485+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:29:43.485+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:29:43.485+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:29:43.485+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:29:43.485+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:29:43.485+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:29:43.546+0900 W/CRASH_MANAGER( 8901): worker.c: worker_job(1199) > 0608257636c691491416983
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.499+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:29:47.509+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:29:47.509+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:30:00.492+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:30:00.492+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:30
04-06 03:30:00.492+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:30"
04-06 03:30:00.492+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:30"
04-06 03:30:00.492+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:30:00.492+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146640302 Time: <font_size=31> </font_size> <font_size=31> 오전 3:30</font_size></font>"
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.334+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-06 03:30:23.344+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:30:23.344+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-06 03:31:00.501+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:31:00.501+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:31
04-06 03:31:00.501+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:31"
04-06 03:31:00.501+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:31"
04-06 03:31:00.501+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:31:00.501+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146607984 Time: <font_size=31> </font_size> <font_size=31> 오전 3:31</font_size></font>"
04-06 03:31:18.959+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=214998322
04-06 03:31:19.039+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=214998399
04-06 03:31:19.039+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 03:31:19.039+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 03:31:19.039+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 03:31:19.049+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:31:19.049+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:31:19.049+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 03:31:19.049+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 03:31:19.049+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 03:31:19.069+0900 I/abc     ( 8892): abc
04-06 03:31:19.069+0900 I/CAPI_APPFW_APPLICATION( 8892): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:31:19.069+0900 I/CAPI_APPFW_APPLICATION( 8892): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:31:19.089+0900 E/TBM     ( 8892): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:31:19.149+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8892, appid: org.example.client
04-06 03:31:19.149+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:31:19.159+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(8892)
04-06 03:31:19.349+0900 D/basicui ( 8892): successed to load edc file
04-06 03:31:19.379+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:31:19.379+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:31:19.399+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:31:19.399+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:31:19.399+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:31:19.409+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:31:19.439+0900 I/MY_LOG  ( 8892): change
04-06 03:31:19.479+0900 I/APP_CORE( 8892): appcore-efl.c: __do_app(514) > [APP 8892] Event: RESET State: CREATED
04-06 03:31:19.479+0900 I/CAPI_APPFW_APPLICATION( 8892): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:31:19.489+0900 E/EFL     ( 8892): edje<8892> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:31:19.489+0900 E/EFL     ( 8892): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:31:19.499+0900 E/EFL     ( 8892): edje<8892> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:31:19.499+0900 E/EFL     ( 8892): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:31:19.499+0900 E/EFL     ( 8892): edje<8892> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:31:19.499+0900 E/EFL     ( 8892): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:31:19.509+0900 W/APP_CORE( 8892): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-06 03:31:19.509+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:31:19.609+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:31:19.609+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:31:19.609+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:31:19.609+0900 I/APP_CORE( 8892): appcore-efl.c: __do_app(514) > [APP 8892] Event: RESUME State: CREATED
04-06 03:31:19.619+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:31:19.619+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:31:19.619+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:31:19.619+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8892) status(3)
04-06 03:31:19.619+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(8892)
04-06 03:31:19.619+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8892, appid: org.example.client, status: fg
04-06 03:31:19.629+0900 I/APP_CORE( 8892): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:31:19.629+0900 I/APP_CORE( 8892): appcore-efl.c: __do_app(625) > [APP 8892] Initial Launching, call the resume_cb
04-06 03:31:19.629+0900 I/CAPI_APPFW_APPLICATION( 8892): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:31:19.629+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:31:19.629+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:31:19.629+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:31:19.980+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8892) status(0)
04-06 03:31:20.210+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2020
04-06 03:31:20.210+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 03:31:20.210+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 8892.
04-06 03:31:21.001+0900 I/UXT     ( 8965): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 03:31:21.391+0900 E/EFL     ( 8892): ecore_x<8892> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215000754
04-06 03:31:21.471+0900 E/EFL     ( 8892): ecore_x<8892> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215000831
04-06 03:31:23.933+0900 E/EFL     ( 8892): ecore_x<8892> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215003292
04-06 03:31:23.933+0900 I/MY_LOG  ( 8892): Button pressed
04-06 03:31:24.034+0900 E/EFL     ( 8892): ecore_x<8892> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215003403
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: vconf_get_bool(2729) > vconf_get_bool(8892) : db/ise/keysound error
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:31:24.044+0900 E/VCONF   ( 8892): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:31:24.094+0900 I/MY_LOG  ( 8892): Button unpressed
04-06 03:31:24.234+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:31:24.234+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8892 pgid = 8892
04-06 03:31:24.234+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(8892)
04-06 03:31:24.244+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:31:24.244+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:31:24.244+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:31:24.244+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:31:24.244+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:31:24.284+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:31:24.284+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:31:24.284+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:31:24.284+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 8892
04-06 03:31:24.284+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[8892] terminate event is forwarded
04-06 03:31:24.284+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:31:24.284+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 8892, ]
04-06 03:31:24.284+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:31:24.284+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:31:24.284+0900 I/Tizen::App( 1231): (512) > Not registered pid(8892)
04-06 03:31:24.284+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:31:24.284+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:31:24.284+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8892
04-06 03:31:24.284+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8892
04-06 03:31:24.294+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2024
04-06 03:31:24.294+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:31:24.304+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:31:24.304+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 8892.
04-06 03:31:24.314+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:31:24.314+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:31:24.314+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:31:24.314+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:31:24.344+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:31:24.344+0900 W/CRASH_MANAGER( 8972): worker.c: worker_job(1199) > 0608892636c691491417084
04-06 03:31:24.374+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:31:24.374+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:31:24.374+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:31:24.374+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:31:24.374+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:31:24.374+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:31:24.374+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:31:24.384+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:31:24.404+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:31:24.434+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:31:24.454+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7935738]
04-06 03:31:24.454+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:31:24.454+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7935738
04-06 03:31:24.454+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:31:24.454+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:31:24.454+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:31:24.454+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:31:24.454+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:31:50.149+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215029508
04-06 03:31:50.209+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215029574
04-06 03:31:50.209+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-06 03:31:50.209+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
04-06 03:31:50.219+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 858
04-06 03:31:50.229+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-06 03:31:50.229+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-06 03:31:50.229+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-06 03:31:50.229+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-06 03:31:50.229+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-06 03:31:50.239+0900 I/abc     ( 8965): abc
04-06 03:31:50.239+0900 I/CAPI_APPFW_APPLICATION( 8965): app_main.c: ui_app_main(789) > app_efl_main
04-06 03:31:50.239+0900 I/CAPI_APPFW_APPLICATION( 8965): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-06 03:31:50.269+0900 E/TBM     ( 8965): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-06 03:31:50.329+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8965, appid: org.example.client
04-06 03:31:50.329+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-06 03:31:50.329+0900 W/AUL     (  858): launch.c: app_request_to_launchpad(425) > request cmd(1) result(8965)
04-06 03:31:51.360+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2026
04-06 03:31:51.370+0900 I/Tizen::App( 1231): (499) > LaunchedApp(org.example.client)
04-06 03:31:51.370+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for org.example.client, 8965.
04-06 03:31:52.081+0900 I/UXT     ( 9032): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-06 03:31:55.334+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(8965)
04-06 03:31:55.334+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8965, appid: org.example.client, status: bg
04-06 03:32:00.509+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(195) > ""
04-06 03:32:00.509+0900 E/UXT     (  661): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 3:32
04-06 03:32:00.509+0900 I/INDICATOR(  661): clock.c: getTimeFormatted(176) > "time format : 오전 3:32"
04-06 03:32:00.509+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 3:32"
04-06 03:32:00.509+0900 W/INDICATOR(  661): clock.c: indicator_clock_changed_cb(272) > 
04-06 03:32:00.509+0900 I/INDICATOR(  661): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146539312 Time: <font_size=31> </font_size> <font_size=31> 오전 3:32</font_size></font>"
04-06 03:32:12.351+0900 D/basicui ( 8965): successed to load edc file
04-06 03:32:12.381+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:32:12.381+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:32:12.431+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-06 03:32:12.431+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:32:12.441+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:32:12.451+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:32:12.471+0900 I/MY_LOG  ( 8965): change
04-06 03:32:12.511+0900 I/APP_CORE( 8965): appcore-efl.c: __do_app(514) > [APP 8965] Event: RESET State: CREATED
04-06 03:32:12.511+0900 I/CAPI_APPFW_APPLICATION( 8965): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-06 03:32:12.531+0900 E/EFL     ( 8965): edje<8965> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:32:12.531+0900 E/EFL     ( 8965): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:32:12.531+0900 E/EFL     ( 8965): edje<8965> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:32:12.531+0900 E/EFL     ( 8965): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:32:12.531+0900 E/EFL     ( 8965): edje<8965> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-06 03:32:12.531+0900 E/EFL     ( 8965): By the power of Grayskull, your previous Embryo stack is now broken!
04-06 03:32:12.541+0900 W/APP_CORE( 8965): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7200002
04-06 03:32:12.541+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-06 03:32:12.651+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-06 03:32:12.651+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-06 03:32:12.651+0900 I/APP_CORE( 8965): appcore-efl.c: __do_app(514) > [APP 8965] Event: RESUME State: CREATED
04-06 03:32:12.651+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-06 03:32:12.661+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-06 03:32:12.661+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-06 03:32:12.661+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-06 03:32:12.661+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8965) status(3)
04-06 03:32:12.661+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:32:12.661+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:32:12.661+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(8965)
04-06 03:32:12.661+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8965, appid: org.example.client, status: fg
04-06 03:32:12.671+0900 I/APP_CORE( 8965): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-06 03:32:12.671+0900 I/APP_CORE( 8965): appcore-efl.c: __do_app(625) > [APP 8965] Initial Launching, call the resume_cb
04-06 03:32:12.671+0900 I/CAPI_APPFW_APPLICATION( 8965): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:32:12.671+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-06 03:32:12.671+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-06 03:32:12.671+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-06 03:32:13.011+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8965) status(0)
04-06 03:32:15.654+0900 E/EFL     ( 8965): ecore_x<8965> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=215055021
04-06 03:32:15.654+0900 I/MY_LOG  ( 8965): Button pressed
04-06 03:32:15.744+0900 E/EFL     ( 8965): ecore_x<8965> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=215055110
04-06 03:32:15.744+0900 E/VCONF   ( 8965): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-06 03:32:15.744+0900 E/VCONF   ( 8965): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-06 03:32:15.744+0900 E/VCONF   ( 8965): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-06 03:32:15.744+0900 E/VCONF   ( 8965): vconf.c: vconf_get_bool(2729) > vconf_get_bool(8965) : db/ise/keysound error
04-06 03:32:15.744+0900 E/VCONF   ( 8965): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-06 03:32:15.744+0900 E/VCONF   ( 8965): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-06 03:32:15.804+0900 I/MY_LOG  ( 8965): Button unpressed
04-06 03:32:15.944+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:32:15.954+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-06 03:32:15.954+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-06 03:32:15.954+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-06 03:32:15.954+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-06 03:32:15.954+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-06 03:32:15.974+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8965 pgid = 8965
04-06 03:32:15.974+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(8965)
04-06 03:32:16.014+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-06 03:32:16.014+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-06 03:32:16.014+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-06 03:32:16.014+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-06 03:32:16.024+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 8965
04-06 03:32:16.024+0900 I/Tizen::App( 1231): (243) > App[org.example.client] pid[8965] terminate event is forwarded
04-06 03:32:16.024+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-06 03:32:16.024+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [org.example.client, 8965, ]
04-06 03:32:16.024+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-06 03:32:16.024+0900 I/Tizen::App( 1231): (506) > TerminatedApp(org.example.client)
04-06 03:32:16.024+0900 I/Tizen::App( 1231): (512) > Not registered pid(8965)
04-06 03:32:16.024+0900 I/Tizen::System( 1231): (246) > Terminated app [org.example.client]
04-06 03:32:16.024+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:32:16.024+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8965
04-06 03:32:16.024+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8965
04-06 03:32:16.024+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-06 03:32:16.024+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-06 03:32:16.024+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-06 03:32:16.024+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-06 03:32:16.024+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2030
04-06 03:32:16.034+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-06 03:32:16.054+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:32:16.054+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for org.example.client, 8965.
04-06 03:32:16.074+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-06 03:32:16.094+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-06 03:32:16.094+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:32:16.094+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [org.exampl] 
04-06 03:32:16.094+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-06 03:32:16.094+0900 I/TIZEN_N_SOUND_MANAGER(  912): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-06 03:32:16.094+0900 E/TIZEN_N_SOUND_MANAGER(  912): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-06 03:32:16.094+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-06 03:32:16.104+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-06 03:32:16.124+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-06 03:32:16.134+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7b6a830]
04-06 03:32:16.134+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-06 03:32:16.134+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7b6a830
04-06 03:32:16.134+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-06 03:32:16.144+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-06 03:32:16.144+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-06 03:32:16.144+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-06 03:32:16.144+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-06 03:32:16.154+0900 W/CRASH_MANAGER( 9043): worker.c: worker_job(1199) > 0608965636c69149141713
